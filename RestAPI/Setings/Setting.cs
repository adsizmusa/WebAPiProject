using RestAPI.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.RestApi
{
    public class Setting
    {
        public string BaseUrl { get; set; }
        public Setting(BaseEnumType baseEnumType)
        {
            switch (baseEnumType)
            {
                case BaseEnumType.Live:
                    {
                        BaseUrl = "http://localhost:62257/";
                        break;
                    }
                case BaseEnumType.Test:
                    {
                        BaseUrl = "http://localhost:62257/";
                        break;
                    }
                default: break;
            }
        }
    }
}
