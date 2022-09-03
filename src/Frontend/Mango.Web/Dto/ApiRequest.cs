using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Dto
{
    public class ApiRequest
    {
        public ApiRequestType ApiType { get; set; } = ApiRequestType.GET;

        public string Url { get; set; }

        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
