using BussinessDTO.DTOs;
using Newtonsoft.Json;
using RestAPI.Enums;
using RestAPI.Helper;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.RestApi
{
    public class RequestRestApi
    {
        Setting setting;
        public AuthResponse _authResponse { get; set; }
        public RequestRestApi()
        {

            if (Debugger.IsAttached)
            {
#if (DEBUG)
                setting = new Setting(BaseEnumType.Test);
                // setting = new Setting(BaseType.Live);
#endif
            }
            else
            {


                setting = new Setting(BaseEnumType.Live);




            }

        }
        protected TResult Get<TResult>(string URL, string param)
        {
            TResult t = default(TResult);
            Task.Run(() =>
            {
                try
                {
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(setting.BaseUrl + URL + param);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Accept = "application/json";
                    httpWebRequest.Method = "GET";
                    httpWebRequest.Timeout = 100000;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                    if (_authResponse.Token != null)
                    {
                        httpWebRequest.Headers.Add("Authorization", "Bearer " + _authResponse.Token);
                        httpWebRequest.Headers.Add("MemberId", _authResponse.MemberId.ToString());
                    }

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        t = JsonConvert.DeserializeObject<TResult>(result);
                    }
                }
                catch (Exception ex)
                {

                }


            }).Wait();
            return t;
        }
        protected TResult Post<TResult, TReguest>(string URL, TReguest param)
        {
            TResult t = default(TResult);
            Task.Run(() =>
            {
                try
                {
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(setting.BaseUrl + URL);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Accept = "application/json";
                    httpWebRequest.Method = "POST";
                    httpWebRequest.Timeout = 100000;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    if (_authResponse.Token != null)
                    {
                        httpWebRequest.Headers.Add("Authorization", "Bearer " + _authResponse.Token);
                        httpWebRequest.Headers.Add("MemberId", _authResponse.MemberId.ToString());
                    }

                    if (param != null)
                    {
                        ClassConvertString ccs = new ClassConvertString(param);
                        ASCIIEncoding encoding = new ASCIIEncoding();
                        Byte[] bytes = encoding.GetBytes(ccs.JsonString);

                        Stream newStream = httpWebRequest.GetRequestStream();
                        newStream.Write(bytes, 0, bytes.Length);
                        newStream.Close();
                    }


                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        t = JsonConvert.DeserializeObject<TResult>(result);
                    }
                }
                catch (Exception ex)
                {


                }

            }).Wait();
            return t;
        }

    }
}
