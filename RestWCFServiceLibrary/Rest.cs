using LeitoraToledo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web.Script.Serialization;

namespace RestWCF
{
    public class Rest : IRest
    {
        public string JsonData(string id)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            HttpResponseMessageProperty prop = new HttpResponseMessageProperty();
            Response r = new Response()
            {
                data = new Result()
                {
                    Id = 1,
                    Name = "Danilo"
                }
            };

            prop.Headers.Add("Access-Control-Allow-Origin", "*");
            OperationContext.Current.OutgoingMessageProperties.Add(HttpResponseMessageProperty.Name, prop);            

            return js.Serialize(r);
        }
    }
    public class Result
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}