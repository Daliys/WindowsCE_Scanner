using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace CS_Barcode2ControlSample1
{
    class NetThread
    {
        //private int port = 80;
        //private string server = "192.168.31.236";

        public String mess = "Не соединено";
        public String response = "";
        public String response2 = "";
        public String response5 = "";
        public bool update = false;
        public void connect()
        {
            /*TcpClient client1 = new TcpClient();
            IPAddress ipa = IPAddress.Parse("178.124.211.97");
            try
            {
                if (!client1.Client.Connected)
                    client1.Connect(ipa, 80);
                string response1 = "POST http://pro.api.ti-service.by/api/v1/operator/device_action HTTP/1.1\r\n"+
                                    "Host: pro.api.ti-service.by\r\n"+
                                    "accept: application/json\r\n"+
                                    "Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI0IiwianRpIjoiYWZkNGYxNDY1ZTI4YmYwZmM1NzNmODYzYWI3NGM5Mzk0Zjc4YWFhODMyZDE2NWVkYWEyNjkxOTU0MjdkNGMzMjAyODEzMDFkNjY4Yjc2OTMiLCJpYXQiOjE2MTQwMDIwODYsIm5iZiI6MTYxNDAwMjA4NiwiZXhwIjoxNjQ1NTM4MDg2LCJzdWIiOiIyZTRkOTI5Mi03YjgxLTRiYmItODZhYS1jYjU0YmVkMWQ0NmYiLCJzY29wZXMiOlsib3BlcmF0b3IiXX0.dNQ1eXC64ekfvB2kSIy_PegbWl7ZkPky9XdHxjgdxdpDhVhIUzPzj1ifvsgKr_PEQOZ7G11rh2Xs_dvwXXwUxJczkxxnjli0L0bVpP6YaDJ6QVZANiGYJn0KDumVlIjqRviCMo4ICAhM7F-0UMY_7LWFkzrVDyAxG7PFHHFmf98VwypqLd5-sj4B4ABmybf9icGqUtC1WtKDe7xwiedMWEe4c7Xl0nV1x1-vRfgG08jjV6G2EAxb7TBPmsmHD7tyy6L-2div9GqP_dGxBRH6PqWEslb33XKoTgaw5BSUFHl-XFsRMxaPy0tERZrgQ1KLFwNTF0mh-JFUhcjwW-VF12V-A1RozceGCbfeB_8zLliv1qZCTa9SYNb_sY2tOC2ZXZKwqOmK5TxUg4fs2VMOyMUV26elSTFf-HrQ1ug-5b3diBsJc-c1vG-QyIVejkpqoEHSueVpvR1xpJk3f9pDyT5KgAMXWPTq1EcBCU6pFn9KCI1w_08wEKYcwQshKNjoTOw4NVyoMMgamrQIABgMK9vl6IpiNLLv3mSpQThOzYauGq5EAPhCkUs_YaIQOuV3Upa-X7wfT_LQlk7fFR_Hy_KNoC1UhMTJzdR_y5VUQBpZx2y_Py2x6VIaxkPGDAF5QrFWssEtNWjgaMP6DFojpF8U5klYKaW6doSDPC1wCpQ\r\n"+
                                    "Content-Type: application/x-www-form-urlencoded\r\n"+
                                    "Content-Length: 49\r\n\r\n"+
                                    "id=11cdb2d6-54d6-40de-b390-58476822adf3&type=open\r\n";
                Byte[] data1 = Encoding.UTF8.GetBytes(response1);
                if (client1.Client != null)
                {
                    NetworkStream stream1 = client1.GetStream();
                    //StringBuilder response = new StringBuilder();
                    if (stream1 != null)
                    {
                        stream1.Write(data1, 0, data1.Length);
                        byte[] data = new byte[256];
                        response2 = "";
                        UInt32 i = 0;
                        while (stream1.DataAvailable || i<1000000)
                        {
                            int bytes = stream1.Read(data, 0, data.Length);
                            response2=response2+(Encoding.UTF8.GetString(data, 0, bytes));
                            if (response2.Length > 13)
                            {
                                update = true;
                                response5 = ""+response2[9] + response2[10] + response2[11];
                                break;
                            }
                            i++;
                        }
                        stream1.Close();
                        mess = "Соединено";
                    }

                    //client1.Client.Close();

                }
            }
            catch
            {
                mess = "Ошибка";
            }*/
           


        }


        public void sendCode()
        {
            TcpClient client1 = new TcpClient();
            IPAddress ipa = IPAddress.Parse("178.124.211.97");
            try
            {
                if (!client1.Client.Connected)
                    client1.Connect(ipa, 80);
                if (client1.Client.Connected) mess = "Соединено";
                String response_ticket = "GET http://tickets-api.ti-service.by/api/v1/operator/tickets/?code="+response+"&type=enter HTTP/1.1\r\n" +
                                         "Host: tickets-api.ti-service.by\r\n" +
                                         "accept: application/json\r\n" +
                                         "Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxIiwianRpIjoiYjFjNTQxZGQ1OGYxNmE5MjU2ZjI3YzNmOTQzMjQ1MTc2N2U0NGFjMThmMGYyYTRjYzJmZGU4OTQ4NWFlYjY0ZWJkMDNjZDZhMTJjZDZjNjgiLCJpYXQiOjE2MTYxODIxNTUsIm5iZiI6MTYxNjE4MjE1NSwiZXhwIjoxNjQ3NzE4MTU1LCJzdWIiOiIzY2IxYjZhNy00OWMxLTQzZDgtYTljMy1kYmVkZTEzY2RlZTEiLCJzY29wZXMiOlsib3BlcmF0b3IiXX0.Qpi1Jkx7n2zMr7ezteH61K05R5LEibToocG3olDOGAYHrFJiUdGeLDWUIVR4MucYwyIInA_0WyBUcKtkIymQCf9GNOGD95iYAbMTP0Q_LzA8CNnaQsoBa_FkPTDNlM4otKfHYppIzRdMhOediFLPDBrZTunBYmcjwOMjRi4S_BE4pnlb6w1VMkrU0X5rvZ65uFxxXgapr0--tDDJQJX0jCcKy_0pavSUmG5tREG7rmU6pxFrgBCaN42iffk-6tSu8EXTz34zYba8o_q0-rAh06N5i9w0C8XhJgKQ1FkIPee2i5XA7350k4gMlgw6mtdb04yI8oQW0Wi5cIqPazJgSWKhZp9-cGol-jcRbbaLoZbPnE6Jb_spEewbxh14e7krv3_ZK_gYqD6141ocTINIu5AKxp2pozH88WXnBqZH7TQubH55UE5twW9RGteXcp69h6gEvXZWAAFLMZM8Y3uDOSOXS4JuSoeGk6UBHU_XiBzWBO-xv4IQiIivJa21JN5uTxrFHqk5Yaor6eirLqBQP-5-oU4n2578ne3gWTdXgACM4r8m4ULV5sf1UxRtjuvvD2BOhxVjD4leWrKF6RF-Wj2bGAmbLqXY7GyHXJFJtnnazgnmdb85CgJJhgUWWVEj9uXPBpE-2hhE08yWX7BC59PbpNBF0YKnrP3Ov6geKlE\r\n" +
                                         "Content-Type: application/x-www-form-urlencoded\r\n\r\n";
                    
              
                Byte[] data1 = Encoding.UTF8.GetBytes(response_ticket);
                if (client1.Client != null)
                {
                    NetworkStream stream1 = client1.GetStream();
                    stream1.Flush();
                    if (stream1 != null)
                    {
                        stream1.Write(data1, 0, data1.Length);
                        byte[] data = new byte[256];
                        response2 = "";
                        UInt32 i = 0;
                        while (stream1.DataAvailable || i < 1000000)
                        {
                            int bytes = stream1.Read(data, 0, data.Length);
                            response2 = response2 + (Encoding.UTF8.GetString(data, 0, bytes));
                            if (response2.Length > 13)
                            {
                                update = true;
                                response5 = "" + response2[9] + response2[10] + response2[11];
                                break;
                            }
                            i++;
                        }
                        stream1.Flush();
                        stream1.Close();
                    }
                    //client1.Client.Close();

                }
            }
            catch
            {
                mess = "Ошибка";
            }

        }

    }
}
