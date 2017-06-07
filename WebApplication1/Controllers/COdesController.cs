using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class COdesController : ApiController
    {
        [HttpGet]
       [Custom]
        [Route("api/Login")]
        public HttpResponseMessage Get(string code)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(code, Encoding.UTF8, "text/plain")
            };
        }
    }
}
