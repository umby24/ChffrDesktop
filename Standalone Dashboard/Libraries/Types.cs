using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Standalone_Dashboard.Libraries {
    public class ChffrToken {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }

    public class GoogleToken {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        [JsonProperty("id_token")]
        public string IdToken { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }

    public class ChffrUserInfo {
        public string Email { get; set; }
        public string Id { get; set; }
        public int Points { get; set; }
        [JsonProperty("upload_video")]
        public bool UploadVideo { get; set; }
        public string Username { get; set; }
    }

    public class RouteCollection {
        public Dictionary<string, Route> Routes { get; set; }
        public int Total { get; set; }
    }

    public class Route {
        public float Len { get; set; }
        public int MaxCamera { get; set; }
        public int MaxLog { get; set; }
        public bool Movie { get; set; }
        public int PieceCount { get; set; }
        public int ProcCamera { get; set; }
        public int ProcLog { get; set; }
        public string Url { get; set; }
    }
}
