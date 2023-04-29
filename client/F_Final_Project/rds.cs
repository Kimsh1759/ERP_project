﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Security.Policy;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.AxHost;

namespace F_Final_Project
{
    public class RDSserver
    {
        string ip = "http://192.168.0.9:8080";
        //java - http://192.168.0.9:8080   ec2 java - http://13.209.6.6:8080
        public List<string> menutype_string = new List<string>() { "name", "PW", "addr", "tel", "mail", "img" };
        public List<string> menutype_int = new List<string>() { "employeeNumber", "authority", "team", "JG", "birth", "DoE" };

        public RDSserver()
        {
            List<JObject> list = Readdic_database("Team");
            foreach (JObject i in list)
            {
                try
                {
                    team_dic.Add(Convert.ToInt32(i["teamID"]), i["team"].ToString());
                    teamDoc_dic.Add(i["team"].ToString(), i["DocChar"].ToString());
                }
                catch { }
            }
        }

        public Dictionary<int, string> JG_dic = new Dictionary<int, string>()
        {
            {0, "사장" },
            {1, "상무" },
            {2, "이사" },
            {3, "부장" },
            {4, "차장" },
            {5, "과장" },
            {6, "대리" },
            {7, "사원" },
        };
        public Dictionary<int, string> team_dic = new Dictionary<int, string>()
        {
            {0, "인사" },
            {1, "영업" },
            {2, "개발" }
        };
        public Dictionary<string, string> teamDoc_dic = new Dictionary<string, string>();
        public Dictionary<int, string> authority_dic = new Dictionary<int ,string>()
        {
            {2,"사원" },
            {1,"팀장급" },
            {0 , "관리자" }
        };



        // database C.R.U.D
        public void Create_database(List<object> list, string tableType) // tableType =  "UserInfo"
        {
            if (tableType == "UserInfo")
            {
                string url = string.Format("{0}/AddUserInfo", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";

                    var data = new
                    {
                        employeeNumber = Convert.ToInt32(list[0]),
                        name = Convert.ToString(list[1]),
                        PW = Convert.ToInt32(list[2]),
                        authority = Convert.ToInt32(list[3]),
                        team = Convert.ToInt32(list[4]),
                        JG = Convert.ToInt32(list[5]),
                        birth = Convert.ToInt32(list[6]),
                        addr = Convert.ToString(list[7]),
                        tel = Convert.ToString(list[8]),
                        mail = Convert.ToString(list[9]),
                        DoE = Convert.ToInt32(list[10])
                    };

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
            else if (tableType == "NoticeBoard")
            {
                string url = string.Format("{0}/Addnotice", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var data = new { num = list[0], name = list[1], title = list[2], content = list[3], wdate = list[4], division = list[5], id = list[6] };

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
            else if (tableType == "FreeBoard")
            {
                string url = string.Format("{0}/Addpost", ip);
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var data = new { num = list[0], name = list[1], title = list[2], content = list[3], wdate = list[4], division = list[5], id = list[6] };

                    string json = JsonConvert.SerializeObject(data);
                    string result = client.UploadString(url, json);
                }
            }
        }

        public void Create_database(int employeeNumber, string Mdate, string Memo) // tableType =  "MyPage"
        {
            string url = string.Format("{0}/AddMemo", ip);

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                var data = new { num = employeeNumber, date = Convert.ToInt32(Mdate), memo = Memo };

                string json = JsonConvert.SerializeObject(data);
                string result = client.UploadString(url, json);
            }
        }

        public List<JObject> Readdic_database(string table_name, int state=0)
        {
            string url;
            Dictionary<string, object> result = new Dictionary<string, object>();
            List<Dictionary<string, object>> dic_list = new List<Dictionary<string, object>>();
            List<JObject> list = new List<JObject>();
            if (table_name == "NoticeBoard" || table_name == "FreeBoard")
            {
                url = string.Format("{0}/ReadBoard?table={1}", ip, table_name);
                list = CallApiss(url);
            }
            else if(table_name == "ApplicationForLeave" || table_name == "Draft" || table_name == "journal" && state != -1)
            {
                url = string.Format("{0}/ReadAllElectric?table={1}&state={2}", ip, table_name,state.ToString());
                list = CallApiss(url);
            }
            else
            {
                url = string.Format("{0}/ReadAll?table={1}", ip, table_name);
                list = CallApiss(url);
            }


            try
            {
                foreach (JObject i in result.Values)
                {
                    list.Add(i);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return list;
        }

        public List<JObject> Readdic_database(string table, string name, int state,string division)
        {
            string url;
            Dictionary<string, object> result = new Dictionary<string, object>();
            List<JObject> list = new List<JObject>();
            if (division == "writer")
            {
                url = string.Format("{0}/ReadDataElectricSelf?table={1}&writer={2}&state={3}", ip, table, name,state);
                list = CallApiss(url);
            }
            else if(division == "team")
            {
                url = string.Format("{0}/ReadElectricTeam?table={1}&team={2}&state={3}", ip, table, name,state);
                list = CallApiss(url);
            }

            
            try
            {
                foreach (JObject i in result.Values)
                {
                    list.Add(i);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return list;
        }

        public JObject Read_database2(string table, string id)
        {
            JObject obj = new JObject();
            string url="";
                url = string.Format("{0}/ReadElectric?table={1}&id={2}", ip, table,id);
                obj = CallApiJ(url);
            

            return obj;
        }

        public List<object> Read_database(string table_name) // ex) table_name = "UserInfo"
        {
            string url;
            Dictionary<string, object> result = new Dictionary<string, object>();
            List<object> list = new List<object>();
            List<Dictionary<string, object>> dic_list = new List<Dictionary<string, object>>();

            if (table_name == "NoticeBoard" || table_name == "FreeBoard")
            {
                url = string.Format("{0}/ReadBoard?table={1}", ip, table_name);
                dic_list = CallApis(url);
            }
            else
            {
                url = string.Format("{0}/ReadAll?table={1}", ip, table_name);
                result = CallApi(url);
            }


            try
            {
                if (table_name == "UserInfo")
                {
                    foreach (JObject i in result.Values)
                    {
                        list.Add(i["employeeNumber"]);
                        list.Add(i["name"]);
                        list.Add(i["PW"]);
                        list.Add(i["authority"]);
                        list.Add(team_dic[(int)i["team"]]);
                        list.Add(JG_dic[(int)i["JG"]]);
                        list.Add(i["birth"]);
                        list.Add(i["addr"]);
                        list.Add(i["tel"]);
                        list.Add(i["mail"]);
                        list.Add(i["DoE"]);
                    }
                }
                else if (table_name == "MyPage")
                {
                    foreach (JObject i in result.Values)
                    {
                        list.Add(i["memo"]);
                    }
                }
                else if (table_name == "ElectronicPayment")
                {
                    foreach (JObject i in result.Values)
                    {
                        list.Add(i["employeeNumber"]);
                        list.Add(i["docTitle"]);
                        list.Add(i["docContent"]);
                        list.Add(i["docState"]);
                    }
                }
                else if (table_name == "NoticeBoard")
                {
                    foreach (var i in dic_list)
                    {
                        list.Add(i["name"]);
                        list.Add(i["title"]);
                        list.Add(i["wdate"]);
                        list.Add(i["division"]);
                        list.Add(i["id"]);
                    }
                }
                else if (table_name == "FreeBoard")
                {
                    foreach (var i in dic_list)
                    {
                        list.Add(i["name"]);
                        list.Add(i["title"]);
                        list.Add(i["wdate"]);
                        list.Add(i["division"]);
                        list.Add(i["id"]);
                    }
                }
                else if (table_name == "FreeBoard")
                {
                    foreach (var i in dic_list)
                    {
                        list.Add(i["name"]);
                        list.Add(i["title"]);
                        list.Add(i["wdate"]);
                        list.Add(i["division"]);
                        list.Add(i["id"]);
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return list;
        }
        // Read_database 오버로딩
        public List<object> Read_database(string table_name, int num, string Mdate = null) // ex) table_name = "UserInfo" num=employeeNumber
        {
            List<object> list = new List<object>();
            Dictionary<string, object> result = new Dictionary<string, object>();

            string url = string.Format("{0}/Read?table={1}&num={2}", ip, table_name, num.ToString());

            if (table_name == "MyPage")
            {
                url = string.Format("{0}/ReadMemo?table=MyPage&num={1}&date={2}", ip, num.ToString(), Mdate);
            }
            else if (table_name == "NoticeBoard" || table_name == "FreeBoard")
            {
                url = string.Format("{0}/ReadBoardContent?table={1}&id={2}", ip, table_name, num.ToString());
            }
            result = CallApi(url);


            try
            {
                if (table_name == "UserInfo")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["PW"]);
                    list.Add(result["authority"]);
                    list.Add(team_dic[Convert.ToInt32(result["team"])]);
                    list.Add(JG_dic[Convert.ToInt32(result["JG"])]);
                    list.Add(result["birth"]);
                    list.Add(result["addr"]);
                    list.Add(result["tel"]);
                    list.Add(result["mail"]);
                    list.Add(result["DoE"]);

                }
                else if (table_name == "MyPage")
                {
                    list.Add(result["Memo"]);
                }
                else if (table_name == "ElectronicPayment")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["docTitle"]);
                    list.Add(result["docContent"]);
                    list.Add(result["docState"]);
                }
                else if (table_name == "NoticeBoard")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["title"]);
                    list.Add(result["content"]);
                    list.Add(result["date"]);
                    list.Add(result["division"]);
                    list.Add(result["id"]);
                }
                else if (table_name == "FreeBoard")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["title"]);
                    list.Add(result["content"]);
                    list.Add(result["date"]);
                    list.Add(result["division"]);
                    list.Add(result["id"]);
                }
                else if (table_name == "FingerPrint")
                {
                    list.Add(result["emplyeeNumber"]);
                    list.Add(result["start_time"]);
                    list.Add(result["end_time"]);
                    list.Add(result["date"]);
                }

            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message);
            }
            return list;
        }

        public List<object> Read_database(string table_name, string num) // ex) table_name = "UserInfo" num=employeeNumber
        {
            List<object> list = new List<object>();
            Dictionary<string, object> result = new Dictionary<string, object>();

            string url = string.Format("{0}/Read?table={1}&num={2}", ip, table_name, num.ToString());
            if (table_name == "NoticeBoard" || table_name == "FreeBoard")
            {
                url = string.Format("{0}/ReadBoardContent?table={1}&id={2}", ip, table_name, num.ToString());
            }
            result = CallApi(url);


            try
            {
                if (table_name == "ElectronicPayment")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["docTitle"]);
                    list.Add(result["docContent"]);
                    list.Add(result["docState"]);
                }
                else if (table_name == "NoticeBoard")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["title"]);
                    list.Add(result["content"]);
                    list.Add(result["wdate"]);
                    list.Add(result["division"]);
                    list.Add(result["id"]);
                }
                else if (table_name == "FreeBoard")
                {
                    list.Add(result["employeeNumber"]);
                    list.Add(result["name"]);
                    list.Add(result["title"]);
                    list.Add(result["content"]);
                    list.Add(result["wdate"]);
                    list.Add(result["division"]);
                    list.Add(result["id"]);
                }
                else if (table_name == "FingerPrint")
                {
                    list.Add(result["emplyeeNumber"]);
                    list.Add(result["start_time"]);
                    list.Add(result["end_time"]);
                    list.Add(result["date"]);
                }

            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message);
            }
            return list;
        }
        
        public byte[] ReadImage_database(string table_name, int num)
        {
            byte[] bimage = null;
            try
            {
                string url = string.Format("{0}/ReadImage?table={1}&num={2}", ip, table_name, num.ToString());
                Dictionary<string, object> result = CallApi(url);

                bimage = (byte[])Convert.FromBase64String(result["img"].ToString());

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return bimage;
        }

        public void Update_database(int number, string table_name, string menu, string update)  // ex) menu = select menu / update="update data"
        {
            string url = string.Format("{0}/Update?table={1}&column={2}&data={3}&num={4}", ip, table_name, menu, update, number.ToString());
            Dictionary<string, object> result = CallApi(url);
        }

        public void UpdateBoard_database(List<object> list, string table)
        {
            Delete_database(list[6].ToString(), table);
            Create_database(list, table);
        }

        public void Updatestate( string table, int state, string id)
        {
            string url = string.Format("{0}/UpdateState?table={1}&state={2}&id={3}", ip, table, state, id );
            Dictionary<string, object> result = CallApi(url);
        }

        public void UpdateImage_database(int number, string table_name, string menu, byte[] update)  // ex) menu = select menu / update="update data"
        {
            string url = string.Format("{0}/UpdateImage", ip);
            string imgjson = Convert.ToBase64String(update);

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                var data = new { table = table_name, column = menu, num = number, img = imgjson };

                string json = JsonConvert.SerializeObject(data);
                string result = client.UploadString(url, json);
            }
        }

        public void Delete_database(int number, string table_name) // ex) number = employeenumber / tablename =  "UserInfo"
        {
            string url = string.Format("{0}/Delete?table={1}&num={2}", ip, table_name, number.ToString());
            Dictionary<string, object> result = CallApi(url);
        }

        public void Delete_database(string number, string table_name) // ex) number = board id / tablename =  "NoticeBoard" or "FreeBoard"
        {
            string url = string.Format("{0}/Delete?table={1}&num={2}", ip, table_name, number);
            Dictionary<string, object> result = CallApi(url);
        }

        public Dictionary<string, object> CallApi(string url)
        {
            // HTTP 요청 생성
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            try
            {
                // API 호출 및 응답 처리
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // 응답 데이터를 JSON 형식으로 Deserialize
                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        string jsonContent = reader.ReadToEnd();
                        Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);

                        return result;
                    }
                    else
                    {
                        // 에러 처리
                        throw new Exception($"API 호출에 실패하였습니다. 상태 코드: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                Dictionary<string, object> a = new Dictionary<string, object>();
                return a;
            }

        }

        public List<Dictionary<string, object>> CallApis(string url)
        {
            // HTTP 요청 생성
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            List<Dictionary<string, object>> dic_list = new List<Dictionary<string, object>>();
            Dictionary<string, object> result;
            try
            {
                // API 호출 및 응답 처리
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // 응답 데이터를 JSON 형식으로 Deserialize

                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        string jsonContent = reader.ReadToEnd();
                        dic_list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonContent);

                    }
                    else
                    {
                        // 에러 처리
                        throw new Exception($"API 호출에 실패하였습니다. 상태 코드: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                List<Dictionary<string, object>> a = new List<Dictionary<string, object>>();
                return a;
            }


            return dic_list;

        }

        public List<JObject> CallApiss(string url)
        {
            // HTTP 요청 생성
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            List<JObject> dic_list = new List<JObject>();
            try
            {
                // API 호출 및 응답 처리
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // 응답 데이터를 JSON 형식으로 Deserialize

                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        string jsonContent = reader.ReadToEnd();
                        dic_list = JsonConvert.DeserializeObject<List<JObject>>(jsonContent);

                    }
                    else
                    {
                        // 에러 처리
                        throw new Exception($"API 호출에 실패하였습니다. 상태 코드: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                List<JObject> a = new List<JObject>();
                return a;
            }


            return dic_list;
        }

        public JObject CallApiJ(string url)
        {
            // HTTP 요청 생성
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            JObject obj  = new JObject();
            try
            {
                // API 호출 및 응답 처리
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // 응답 데이터를 JSON 형식으로 Deserialize

                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        string jsonContent = reader.ReadToEnd();
                        obj = JsonConvert.DeserializeObject<JObject>(jsonContent);

                    }
                    else
                    {
                        // 에러 처리
                        throw new Exception($"API 호출에 실패하였습니다. 상태 코드: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                JObject a = new JObject();
                return a;
            }


            return obj;
        }
    }
}