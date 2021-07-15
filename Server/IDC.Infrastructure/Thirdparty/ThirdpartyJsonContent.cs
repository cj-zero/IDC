using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace IDC.Infrastructure.Thirdparty
{
    public  class ThirdpartyJsonContent : StringContent
    {
        public ThirdpartyJsonContent(object obj) :
           base(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")
        { }
    }
}
