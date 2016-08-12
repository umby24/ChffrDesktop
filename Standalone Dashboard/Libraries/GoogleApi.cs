using System;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace Standalone_Dashboard.Libraries {
    public class GoogleApi {
        private const string ClientId = "45471411055-m902j8c6jo4v6mndd2jiuqkanjsvcv6j.apps.googleusercontent.com";
        private const string ClientSecret = "it5cGajZGSHQw5-e2kn2zL_R";
        private const string AuthUrl = "https://accounts.google.com/o/oauth2/token";

        public GoogleToken GetAccessToken(string code) {
            var client = new RestClient(AuthUrl);
            var request = new RestRequest(Method.POST);
            request.AddParameter("code", code);
            request.AddParameter("client_id", ClientId);
            request.AddParameter("client_secret", ClientSecret);
            request.AddParameter("redirect_uri", "urn:ietf:wg:oauth:2.0:oob");
            request.AddParameter("grant_type", "authorization_code");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception("Unexpected response from Google");

            return JsonConvert.DeserializeObject<GoogleToken>(response.Content);
        }
    }
}
