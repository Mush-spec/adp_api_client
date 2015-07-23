using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ADPAPIClient
{
    class HttpClient
    {

        private string protocol;
        private string host;
        private string port;
        private string baseUrl;
        private string response;
            
        public HttpClient()
        {
            this.protocol = "http";
            this.host = "192.168.33.1";
            this.port = "3000";
            this.baseUrl = "api/advocates";
        }


        public string createClaim(string jsonPayload)
        {
            string url = makeUrl("claims.json");
            WebClient client = instantiateClient();
            try
            {
                response = client.UploadString(url, jsonPayload);
            }
            catch (WebException ex)
            {
                response = extractErrorDetails(ex);
            }
            return response;
        }

        private string extractErrorDetails(WebException ex)
        {
            string responseBody = "";
            using (WebResponse response = ex.Response)
            {
                HttpWebResponse httpResponse = (HttpWebResponse)response;
                if (httpResponse != null)
                {
                    if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                    {
                        using (Stream data = response.GetResponseStream())
                        using (var reader = new StreamReader(data))
                        {
                            responseBody = reader.ReadToEnd();
                        }
                    }
                }
                if (responseBody == "")
                {
                    responseBody = "{\"Exception\":\"" + ex.Message + "\"}";
                }
            }
            return responseBody;
        }


        private WebClient instantiateClient()
        {
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Headers["Accept"] = "applicaton/json";
            return client;
        }


        private string makeUrl(string endpoint)
        {
            return protocol + "://" + host + ":" + port + "/" + baseUrl + "/" + endpoint;
        }

    }
}



