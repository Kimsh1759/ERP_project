import pygame, pygame_gui, base64, requests, qrcode
import time, cv2, numpy as np
from pyzbar import pyzbar #qrcode 스캔
from pyzbar.pyzbar import decode
from datetime import datetime
from PIL import Image
from img_encode import Img_encode
from create_qr import Create_qr

url = 'http://192.168.0.46:8080'

pygame.init()
clock = pygame.time.Clock() 
time_delta = clock.tick(60) / 1000.0 # 게임 화면의 초당 프레임 수를 결정

WIDTH = 800
HEIGHT = 480
BLACK = (0,0,0)
WHITE = (255,255,255)
   
def start():
    pygame.init()
    screen = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("Welcome")
    screen.fill((WHITE))
    # UI 매니저 생성
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    # 등록 버튼 생성
    R_button = pygame_gui.elements.UIButton(relative_rect=pygame.Rect((125, 170), (200, 150)),
                                        text='Registration', manager=manager)
    # 출/퇴근 버튼 생성
    W_button = pygame_gui.elements.UIButton(relative_rect=pygame.Rect((485, 170), (200, 150)),
                                        text='Work/Leave', manager=manager)
    exit_button = pygame_gui.elements.UIButton(relative_rect=pygame.Rect((730, 1), (70, 30)), 
                                        text='EXIT', manager=manager)

    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                    running = False
            # 버튼을 클릭하면 로그인 창으로 전환
            if event.type == pygame.USEREVENT:
                if event.user_type == pygame_gui.UI_BUTTON_PRESSED:
                    if event.ui_element == R_button:
                        print('등록 버튼 클릭')
                        login()
                    elif event.ui_element == W_button:
                        print('출퇴근 버튼 클릭')
                        working()
                    elif event.ui_element == exit_button:
                        print('종료')
                        running = False
            # UI 매니저에 이벤트 전달
            manager.process_events(event)
        # UI 매니저 업데이트
        manager.update(time_delta)
        manager.draw_ui(screen)
        pygame.display.flip()   
    pygame.quit()

def error_login():
    pygame.init()
    error_login = pygame.display.set_mode((WIDTH/3, HEIGHT/3))
    pygame.display.set_caption("Fail")
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    
    check_label = pygame_gui.elements.UILabel(
            relative_rect=pygame.Rect((50, 50), (180, 20)),
            text='Login is Fail!',
            manager=manager
        )
    ok_button = pygame_gui.elements.UIButton(
                    relative_rect=pygame.Rect((110, 80), (50, 25)),
                    text='OK',
                    manager=manager,
                )
    
    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            if event.type == pygame.USEREVENT:
                if event.user_type == pygame_gui.UI_BUTTON_PRESSED:
                    if event.ui_element == ok_button:
                        login()
                        
            manager.process_events(event)
        manager.update(time_delta)
        error_login.fill((WHITE))
        manager.draw_ui(error_login)
        pygame.display.flip()
    pygame.quit()
    
def loadqr(qrname):
    pygame.init()
    loadqr = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("QR Code")
    
    # 타이머 설정
    timer = 10000  # 10초를 밀리초로 환산한 값
    timer_limit = 0
    start_ticks = pygame.time.get_ticks()  
    
    image_surface = pygame.image.load(qrname)
    font = pygame.font.SysFont(None, 30, 0.1)
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))

    running = True
    while running:
        # 타이머 갱신
        timer_label = font.render('00 : 0' + str(int((timer - pygame.time.get_ticks() + start_ticks)/1000)) + ' sec', True, BLACK)
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            manager.process_events(event)
        if pygame.time.get_ticks() - start_ticks >= timer:
            start()  
        loadqr.fill((WHITE))
        loadqr.blit(image_surface, (250, 100))
        loadqr.blit(timer_label, (350, 90))
        manager.update(time_delta)
        manager.draw_ui(loadqr)
        pygame.display.flip()
    pygame.quit()

def login():
    pygame.init()
    login = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("Login")
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    login.fill((WHITE))

    username_label = pygame_gui.elements.UILabel(
        relative_rect=pygame.Rect((160, 180), (250, 40)),
        text='ID :',
        manager=manager
    )
    username_textbox = pygame_gui.elements.UITextEntryLine(
        relative_rect=pygame.Rect((310, 180), (250, 40)),
        manager=manager
    )  
    password_label = pygame_gui.elements.UILabel(
        relative_rect=pygame.Rect((160, 250), (250, 40)),
        text='PW :',
        manager=manager,
    )
    password_textbox = pygame_gui.elements.UITextEntryLine(
        relative_rect=pygame.Rect((310, 250), (250, 40)),
        manager=manager
    )
    login_button = pygame_gui.elements.UIButton(relative_rect=pygame.Rect((377, 300), (100, 50)), text='Login', manager=manager)
    home_button = pygame_gui.elements.UIButton(relative_rect=pygame.Rect((730, 1), (70, 30)), text='HOME', manager=manager)

    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            global username 
            username = username_textbox.text
            if event.type == pygame.USEREVENT:
                if event.user_type == pygame_gui.UI_TEXT_ENTRY_CHANGED and event.ui_element == password_textbox:
                    password = password_textbox.text
                    password_textbox.set_text('*' * len(password))
                elif event.user_type == pygame_gui.UI_BUTTON_PRESSED:
                    if event.ui_element == login_button:
                        url_ReadInfo = url+ '/ReadInfo'
                        params = {
                            'employeeNumber': username,
                            'PW': password
                        }
                        response = requests.get(url_ReadInfo, params=params)
                        
                        result = response.json()
                        if result is not None:
                            url_Updateqr = url + '/Updateqr'
                            headers = {'Content-Type' : 'application/json'}
                            data = {
                                'employeeNumber': username,
                                'qrcode': Img_encode(Create_qr(username)),
                            }
                            response = requests.post(url_Updateqr, headers=headers, json=data)

                            qr_image = Image.open(Create_qr(username))
                            qrname = username + '.bmp'
                            loadqr(qrname)
                        else : 
                            error_login()
                    elif event.ui_element == home_button:
                        start()
            manager.process_events(event)
        manager.update(time_delta)
        manager.draw_ui(login)
        pygame.display.flip()
    pygame.quit()

def check_qr():
    pygame.init()
    check_qr = pygame.display.set_mode((WIDTH/2, HEIGHT/2))
    pygame.display.set_caption("OK")
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    check_qr.fill((WHITE))
    check_label = pygame_gui.elements.UILabel(
        relative_rect=pygame.Rect((125, 80), (180, 20)),
        text='QR code confirmed!',
        manager=manager
    )
    ok_button = pygame_gui.elements.UIButton(
                    relative_rect=pygame.Rect((180, 130), (50, 25)),
                    text='OK',
                    manager=manager,
                )
    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            if event.type == pygame.USEREVENT:
                if event.user_type == pygame_gui.UI_BUTTON_PRESSED:
                    if event.ui_element == ok_button:
                        start()
            manager.process_events(event)
        manager.update(time_delta)
        manager.draw_ui(check_qr)
        pygame.display.flip()
    pygame.quit()
    
def working():
    now = datetime.now()
    Date = int(now.date().strftime("%Y%m%d"))
    Time = int(now.time().strftime("%H%M%S"))
    checkQr = False
    pygame.init()
    working = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("QR Code Reader")
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    font = pygame.font.SysFont(None, 30, 0.05)

    cap = cv2.VideoCapture(0)
    cap.set(cv2.CAP_PROP_FRAME_WIDTH, 620)
    cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 380)
    employeeNumber = None
    check_label = pygame_gui.elements.UILabel(relative_rect=pygame.Rect((245, 20), (300, 20)), text='Please recognize the QR code!', manager=manager)
    home_button = pygame_gui.elements.UIButton(relative_rect=pygame.Rect((730, 1), (70, 30)), text='HOME', manager=manager)

    timer = 10000 
    timer_limit = 0  
    start_ticks = pygame.time.get_ticks()
    running = True
    while running:  
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            if event.type == pygame.USEREVENT:
                if event.user_type == pygame_gui.UI_BUTTON_PRESSED:
                    if event.ui_element == home_button:
                        cap.release()
                        start() 
            manager.process_events(event)  
            if pygame.time.get_ticks() - start_ticks >= timer:
                cap.release()
                start()
        timer_label = font.render('00 : ' + str(int((timer - pygame.time.get_ticks() + start_ticks)/1000)) + ' sec', True, BLACK)
        ret, frame = cap.read()
        if ret:
            decoded_objs = decode(frame) # QR 코드 디코딩
            frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
            frame = np.rot90(frame)
            frame = np.flip(frame, axis=0)
            frame = pygame.surfarray.make_surface(frame)
            try:
                for obj in decoded_objs:
                    print("Data:", obj.data) # QR 코드 데이터 출력
                    if obj.data is not None:
                        employeeNumber = int(obj.data.decode('utf-8'))
                        cap.release()
                        url_Readid = url + '/Readid'
                        params = {
                            'employeeNumber': employeeNumber,
                            'date': Date,
                        }
                        response = requests.get(url_Readid, params=params)
                        result_id = response.json()
                        if result_id:
                            Num = int(result_id['num'])
                        else:
                            Num = 0
                        print(Num)
                        url_Updateleave = url + '/Updateleave'
                        params = {
                            'end_time' : Time,
                            'num' : Num,
                        }
                        response = requests.get(url_Updateleave, params=params)
                        checkQr = True
            except Exception as e:
                url_UpdateInfo = url + '/InsertInfo'
                headers = {'Content-Type' : 'application/json'}
                data = {
                    'employeeNumber': employeeNumber,
                    'date': Date,
                    'start_time':Time,           
                }
                response = requests.post(url_UpdateInfo, headers=headers, json=data)
                print("error : ", e)
                checkQr = True
            if checkQr:
                check_qr()
        manager.update(time_delta)
        working.fill((WHITE))
        if ret:
            working.blit(frame, (90, 80))
        working.blit(timer_label, (350, 50))
        manager.draw_ui(working)
        pygame.display.flip()
    pygame.quit()
                  

running = True
while running: 
    start()
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
                running = False
    pygame.display.flip()
pygame.quit()