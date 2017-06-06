using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new OAuthClientTest();
            obj.Get_Accesss_Token_By_Client_Credentials_Grant();
            Console.Read();
        }
        public class OAuthClientTest
        {
            private HttpClient _httpClient;
            public OAuthClientTest()
            {
                _httpClient = new HttpClient();
                _httpClient.BaseAddress = new Uri("http://localhost:52275");
            }

            public void Get_Accesss_Token_By_Client_Credentials_Grant()
            {
                var client = new RestClient(host);
                var request = new RestRequest("/token", Method.POST);
                request.AddParameter("grant_type", "password");
                request.AddParameter("userName", "用户名");
                request.AddParameter("password", "密码");
                //request.AddHeader("Authorization", Convert.ToBase64String(Encoding.ASCII.GetBytes(clientId + ":" + clientSecret)));
                var response = client.Execute(request);
                var s = JObject.Parse(response.Content)["access_token"].Value<string>();
                return s;
            }
        }
    }
}
