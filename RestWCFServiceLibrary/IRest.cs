using System.ServiceModel;
using System.ServiceModel.Web;

namespace RestWCF
{
    [ServiceContract]
    public interface IRest
    {
        [OperationContract]
        [WebInvoke(Method = "GET", 
            ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Wrapped,             
            UriTemplate = "getRest/{id}")]
        string JsonData(string id);
    }
}