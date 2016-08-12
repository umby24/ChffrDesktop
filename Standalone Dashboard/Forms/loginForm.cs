using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Standalone_Dashboard.Libraries;

namespace Standalone_Dashboard.Forms {
    public partial class loginForm : Form {
        private GoogleApi _api;

        public loginForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // -- Verify token
            _api = new GoogleApi();
            try {
                GoogleToken result = _api.GetAccessToken(textBox1.Text);
                var comma = new ChffrApi();
                ChffrToken commaToken = comma.GetAccessToken(result.AccessToken);
                File.WriteAllText("chffr_token", JsonConvert.SerializeObject(commaToken, Formatting.Indented)); // -- Save token to file if correct
            }
            catch (Exception ex) { // -- Token invalid, prompt user
                MessageBox.Show("Failed to verify token. Please try again.", "Login error");
                return;
            }
            
            // -- Close form.
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(
                "https://accounts.google.com/o/oauth2/auth?client_id=45471411055-m902j8c6jo4v6mndd2jiuqkanjsvcv6j.apps.googleusercontent.com&redirect_uri=urn:ietf:wg:oauth:2.0:oob&scope=https://www.googleapis.com/auth/userinfo.email&response_type=code");
        }
    }
}
