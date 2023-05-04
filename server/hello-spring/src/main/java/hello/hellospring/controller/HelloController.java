package hello.hellospring.controller;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.node.ObjectNode;
import hello.hellospring.DTO.HelloDTO;
import hello.hellospring.service.HelloService;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.Base64;

@RestController
public class HelloController {

    HelloService service = new HelloService();

    @GetMapping("ReadAll")
    @ResponseBody
    public String hello(@RequestParam("table") String table) throws JsonProcessingException {
        return service.getAllData(table);
    }

//    @GetMapping("ReadEmployeeNumber")
//    @ResponseBody
//    public String ReadEmployeeNumber(@RequestParam("name") String name) throws JsonProcessingException{
//        return service.getEmployeeNumber(name);
//    }

    @GetMapping("ReadAllElectric")
    @ResponseBody
    public String ReadAllElectric(@RequestParam("table") String table, @RequestParam("state") int state) throws JsonProcessingException {
        return service.getAllDataElectric(table, state);
    }

    @GetMapping("ReadElectric")
    @ResponseBody
    public String ReadElectric(@RequestParam("table") String table, @RequestParam("id") String id) throws JsonProcessingException {
        return service.getElectric(table, id);
    }

    @GetMapping("ReadDataElectricSelf")
    @ResponseBody
    public String ReadDataElectricSelf(@RequestParam("table") String table, @RequestParam("writer") String writer, @RequestParam("state") int state) throws JsonProcessingException
    {
        return service.getAllDataElectricSelf(table, writer, state);
    }
    @GetMapping("ReadElectricTeam")
    @ResponseBody
    public String ReadElectricTeam(@RequestParam("table") String table, @RequestParam("team") String team, @RequestParam("state") int state) throws JsonProcessingException {
        return service.getALLElectricTeam(table, team, state);
    }

    @GetMapping("Read")
    @ResponseBody
    public String Read(@RequestParam("table") String table, @RequestParam("num") int num) throws JsonProcessingException {
        return service.getData(table, num);
    }

    @GetMapping("ReadMemo")
    @ResponseBody
    public String ReadMemo(@RequestParam("table") String table, @RequestParam("num") int num, @RequestParam("date") int date) throws JsonProcessingException {
        return service.getMemo(table, num, date);
    }

    @PostMapping("AddMemo")
    public ResponseEntity<Void> AddMemo(@RequestBody HelloDTO.MemoDTO memoDTO)
    {
        service.addMemo_delete(memoDTO.getNum(), memoDTO.getDate());
        service.addMemo_insert(memoDTO.getNum(), memoDTO.getDate(), memoDTO.getMemo());
        return ResponseEntity.ok().build();
    }

    @PostMapping("AddUserInfo")
    public ResponseEntity<Void> AddUserInfo(@RequestBody HelloDTO.UserInfoDTO userInfoDTO)
    {
        service.UserInfo_add(userInfoDTO);
        return ResponseEntity.ok().build();
    }

    @PostMapping("Addnotice")
    public ResponseEntity<Void> Addnotice(@RequestBody HelloDTO.noticeDTO noticeDTO)
    {
        service.AddNotice(noticeDTO.getNum(), noticeDTO.getName(), noticeDTO.getTitle(), noticeDTO.getContent(), noticeDTO.getWdate(), noticeDTO.getDivision(), noticeDTO.getId());
        return ResponseEntity.ok().build();
    }

    @PostMapping("AddAnnualLeave")
    public ResponseEntity<Void> AddAnnualLeave(@RequestBody HelloDTO.AnnualLeaveDTO annualLeaveDTO) {
        this.service.AddAnnualLeave(annualLeaveDTO.getNum(), annualLeaveDTO.getStart(), annualLeaveDTO.getEnd());
        return ResponseEntity.ok().build();
    }

    @PostMapping("AddQrcode")
    public ResponseEntity<Void> AddQrcode(@RequestBody HelloDTO.AnnualQrcodeDTO annualQrcodeDTO) {
        this.service.AddQrcode(annualQrcodeDTO.getNum(),annualQrcodeDTO.getDate(), annualQrcodeDTO.getStart(), annualQrcodeDTO.getEnd());
        return ResponseEntity.ok().build();
    }

    @PostMapping("AddTeam")
    public ResponseEntity<Void> AddTeam(@RequestBody HelloDTO.TeamDTO teamDTO) {
        this.service.AddTeam(teamDTO.getTeamID(),teamDTO.getTeam(), teamDTO.getTeamDOC());
        return ResponseEntity.ok().build();
    }

    @PostMapping("AddLeaveCount")
    public ResponseEntity<Void> AddLeaveCount(@RequestBody HelloDTO.LeaveCountDTO leaveCountDTO) {
        this.service.AddLeaveCount(leaveCountDTO.getEmployeeNumber(), leaveCountDTO.getCount());
        return ResponseEntity.ok().build();
    }

    @PostMapping("Addpost")
    public ResponseEntity<Void> Addpost(@RequestBody HelloDTO.noticeDTO noticeDTO) {
        this.service.AddPost(noticeDTO.getNum(), noticeDTO.getName(), noticeDTO.getTitle(), noticeDTO.getContent(), noticeDTO.getWdate(), noticeDTO.getDivision(), noticeDTO.getId());
        return ResponseEntity.ok().build();
    }

    @PostMapping("AddApplicationForLeave")
    public ResponseEntity<Void> AddApplicationForLeave(@RequestBody HelloDTO.ApplicationForLeaveDTO applicationForLeaveDTO)
    {
        service.AddApplicationForLeave(applicationForLeaveDTO.getWriter(),applicationForLeaveDTO.getTeam(),applicationForLeaveDTO.getTitle(),
                applicationForLeaveDTO.getStartdate(),applicationForLeaveDTO.getEndDate(),applicationForLeaveDTO.getEmergencyTel(),applicationForLeaveDTO.getReason(),
        applicationForLeaveDTO.getId(),applicationForLeaveDTO.getState(),applicationForLeaveDTO.getType(),applicationForLeaveDTO.getDate());
        return ResponseEntity.ok().build();
    }

    @PostMapping("AddJournal")
    public ResponseEntity<Void> AddJournal(@RequestBody HelloDTO.JournalDTO journalDTO)
    {
        service.Addjournal(journalDTO.getTitle(),journalDTO.getWriter(), journalDTO.getTeam(), journalDTO.getJG(), journalDTO.getDate(),
                journalDTO.getMorning(), journalDTO.getAfternoon(), journalDTO.getSignificant(), journalDTO.getUntreated(), journalDTO.getId(),
                journalDTO.getState(), journalDTO.getType());
        return ResponseEntity.ok().build();
    }

    @PostMapping("AddDraft")
    public ResponseEntity<Void> AddDraft(@RequestBody HelloDTO.DraftDTO draftDTO)
    {
        service.AddDraft(draftDTO.getNumber(), draftDTO.getTeam(), draftDTO.getJG(), draftDTO.getWriter(), draftDTO.getDate(), draftDTO.getTitle(), draftDTO.getRemarks(),
                draftDTO.getDetail(), draftDTO.getId(), draftDTO.getState(), draftDTO.getType());
        return ResponseEntity.ok().build();
    }

    @GetMapping("ReadBoard")
    @ResponseBody
    public String ReadBoard(@RequestParam("table") String table) throws JsonProcessingException {
        return service.getBoard(table);
    }

    @GetMapping("ReadElectronicPayment")
    @ResponseBody
    public String ReadElectronicPayment(@RequestParam("table") String table) throws JsonProcessingException {
        return service.getElectronicPayment(table);
    }

    @GetMapping("ReadBoardContent")
    @ResponseBody
    public String ReadBoardContent(@RequestParam("table") String table, @RequestParam("id") String id) throws JsonProcessingException {
        return service.getBoardContent(table, id);
    }

    @GetMapping("ReadQRdate")
    @ResponseBody
    public String ReadQRdate(@RequestParam("table") String table, @RequestParam("id") int id,@RequestParam("date") int date) throws JsonProcessingException {
        return service.getQRdate(table, id, date);
    }

    @GetMapping("ReadQRdateAll")
    @ResponseBody
    public String ReadQRdateAll(@RequestParam("table") String table, @RequestParam("id") int id) throws JsonProcessingException {
        return service.getQRdateAll(table, id);
    }

    @GetMapping("ReadAllQR")
    @ResponseBody
    public String ReadAllQR(@RequestParam("table") String table, @RequestParam("date") int date) throws JsonProcessingException {
        return service.getAllQR(table, date);
    }

    @GetMapping("Add")
    @ResponseBody
    public ResponseEntity<Void> Add(@RequestParam("table") String table ,@RequestParam("data") String data){
        service.createData(table, data);
        return ResponseEntity.ok().build();
    }

    @GetMapping("Update")
    @ResponseBody
    public ResponseEntity<Void> Update(@RequestParam("table") String table ,@RequestParam("column") String column, @RequestParam("data") String data, @RequestParam("num") int num){
        service.updateData(table, column, data, num);
        return ResponseEntity.ok().build();
    }

    @GetMapping("UpdateTeam")
    @ResponseBody
    public ResponseEntity<Void> Update(@RequestParam("teamID") int teamID, @RequestParam("change") String change){
        service.updateTeam(teamID, change);
        return ResponseEntity.ok().build();
    }

    @GetMapping("UpdateState")
    @ResponseBody
    public ResponseEntity<Void> UpdateState(@RequestParam("table") String table ,@RequestParam("state") int state, @RequestParam("id") String id){
        service.updateState(table, state, id);
        return ResponseEntity.ok().build();
    }
    @GetMapping("Delete")
    @ResponseBody
    public ResponseEntity<Void> Delete(@RequestParam("table") String table, @RequestParam("num") String num){
        try{
            int number = Integer.parseInt(num);
            service.deleteDataInt(table,number);
        }
        catch (NumberFormatException ex){
            service.deleteDataString(table,num);
        }
        return ResponseEntity.ok().build();
    }
    @GetMapping("DeleteTeam")
    @ResponseBody
    public  ResponseEntity<Void> DeleteTeam(@RequestParam("teamID") int teamID)
    {
        service.deleteTeam(teamID);
        return ResponseEntity.ok().build();
    }

    @GetMapping("DeleteLeave")
    @ResponseBody
    public  ResponseEntity<Void> DeleteLeave(@RequestParam("table") String table, @RequestParam("num") int num, @RequestParam("start") int start, @RequestParam("end") int end)
    {
        service.deleteLeave(table, num, start, end);
        return ResponseEntity.ok().build();
    }

    @GetMapping("DeleteQrcode")
    @ResponseBody
    public  ResponseEntity<Void> DeleteQrcode(@RequestParam("table") String table, @RequestParam("num") int num, @RequestParam("date") int date)
    {
        service.deleteQrcode(table, num,date);
        return ResponseEntity.ok().build();
    }

    @PostMapping("UpdateImage")
    public ResponseEntity<String> addImage(@RequestBody HelloDTO.ImageDTO imageDTO) {
        service.UpdateImage(imageDTO.getTable(),imageDTO.getColumn() ,imageDTO.getNum(),imageDTO.getImg());
        return ResponseEntity.ok("Image added successfully");
    }

    @GetMapping("ReadImage")
    public ResponseEntity<ObjectNode> ReadImage(@RequestParam("table") String table, @RequestParam("num") int num) throws JsonProcessingException {
        ObjectNode json = service.ReadImage(table, num);
        return ResponseEntity.ok(json);
    }

}

