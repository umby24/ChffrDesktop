using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace Standalone_Dashboard.Libraries {
    public class ChffrApi {
        public ChffrToken Token { get; set; }
        public const string AuthUrl = "https://api.comma.ai/v1/auth/?access_token={0}";
        public const string BaseUrl = "https://api.comma.ai/v1/";

        public ChffrToken GetAccessToken(string googleToken) {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/auth", Method.GET);
            request.AddQueryParameter("access_token", googleToken);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception("Unexpected response from server.");
            
            var data = JsonConvert.DeserializeObject<ChffrToken>(response.Content);
            return data;
        }

        public ChffrUserInfo GetUserInfo() {
            var client = new RestClient("https://api.comma.ai/");
            var request = new RestRequest("v1/me/", Method.GET);
            client.Encoding = Encoding.ASCII;
            request.AddParameter("Authorization", "JWT " + Token.AccessToken, ParameterType.HttpHeader);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<ChffrUserInfo>(response.Content);
        }

        public RouteCollection GetRoutes() {
            var client = new RestClient("https://api.comma.ai/");
            var request = new RestRequest("v1/me/routes/", Method.GET);
            client.Encoding = Encoding.ASCII;
            request.AddParameter("Authorization", "JWT " + Token.AccessToken, ParameterType.HttpHeader);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<RouteCollection>(response.Content);
        }
    }
}
