using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Standalone_Dashboard.Forms;
using Standalone_Dashboard.Libraries;

namespace Standalone_Dashboard {
    public partial class mainForm : Form {
        private ChffrApi _api;
        private ChffrUserInfo _userInfo;
        private RouteCollection _routes;

        public mainForm() {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e) {
            _api = new ChffrApi();
            CheckAuth();
            LoadData();
            PopulateData();
        }

        private void CheckAuth() {
            if (!File.Exists("chffr_token")) {
                var login = new loginForm();
                login.ShowDialog();
            }

            _api.Token = JsonConvert.DeserializeObject<ChffrToken>(File.ReadAllText("chffr_token"));
        }

        private void LoadData() {
            _userInfo = _api.GetUserInfo();
            _routes = _api.GetRoutes();
        }

        private void PopulateData() {
            Text = "Chffr Dashboard : " + _userInfo.Username;
            lblWelcome.Text = "Welcome, " + _userInfo.Username;
            lblCommaPoints.Text = $"Comma Points: {_userInfo.Points}";

            lstRoutes.Items.Clear();

            foreach (string key in _routes.Routes.Keys) {
                lstRoutes.Items.Add(key);
            }
        }

        private void lstRoutes_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedRoute = _routes.Routes[(string) lstRoutes.SelectedItem];
            lblLength.Text = "Route Length: " + selectedRoute.Len.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            File.Delete("chffr_token");
            CheckAuth();
            LoadData();
            PopulateData();
        }
    }
}
