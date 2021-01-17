using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Helper
{
    public class ClassConvertString
    {
        public string JsonString { get; set; }
        public ClassConvertString(object data)
        {
            if (data != null)
            {
                JsonString = JsonConvert.SerializeObject(data);
            }
            else
            {
                JsonString = "";
            }
        }
    }
}
