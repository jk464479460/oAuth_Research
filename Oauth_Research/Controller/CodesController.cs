using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Oauth_Research
{
    public class CodesController : ApiController
    {
        [HttpGet]
        [Route("api/login")]
        public HttpResponseMessage Getlogin(string code)
        {
            return new HttpResponseMessage
            {
                Content = new StringContent(code, Encoding.UTF8, "text/plain")
            };
        }

       
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}