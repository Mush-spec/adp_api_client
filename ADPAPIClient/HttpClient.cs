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

        public string fullUrl;
        public HttpStatusCode responseStatusCode;
        

        public HttpClient()
        {
            this.protocol = "http";
            this.host = "172.22.6.40";
            this.port = "3000";
            this.baseUrl = "api";
        }

        public string createClaim(string jsonPayload)
        {
            fullUrl = getUrl("external_users/claims.json");
            WebClient client = instantiateClient();
            try
            {
                response = client.UploadString(fullUrl, jsonPayload);
                responseStatusCode = HttpStatusCode.OK;
            }
            catch (WebException ex)
            {
                response = extractErrorDetails(ex);
            }
            return response;
        }

        public string getCourts()
        {
            return getEndpointResponse("courts");
        }

        public string getCaseTypes()
        {
            return getEndpointResponse("case_types");
        }

        // private --------------------------------

        private string getEndpointResponse(string endpointSuffix)
        {
            fullUrl = getUrl(endpointSuffix + "?api_key=" + APIConstants.ApiKey );
            WebClient client = instantiateClient();
            try
            {
                response = client.DownloadString(fullUrl);
                responseStatusCode = HttpStatusCode.OK;
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
                    responseStatusCode = httpResponse.StatusCode;
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


        private string getUrl(string endpoint)
        {
            return protocol + "://" + host + ":" + port + "/" + baseUrl + "/" + endpoint;
        }

    }
}



