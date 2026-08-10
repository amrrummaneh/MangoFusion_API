using System.Net;

namespace MangoFusion_API.Models
{
    public class API_Response
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; } = [];
        public object? Result { get; set; }
    }
}
