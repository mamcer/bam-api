using BamApi.Core;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BamApi.Properties;

namespace BamApi
{
    public partial class Main : Form
    {
        private string _apiUrl;
        private string _bambooHome;
        private NetworkCredential _credentials;
        private delegate void InvokeWriteMessage(string message);
        private ProjectResult _projects;

        public Main()
        {
            InitializeComponent();

            if (!ShowLogin())
            {
                Close();
            }
        }

        private async Task ShowGeneralInfo()
        {
            tabControl.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            lblBuildNumber.Text = Resources.LoadingStatus;
            lblBuildDate.Text = Resources.LoadingStatus;
            lblState.Text = Resources.LoadingStatus;
            lblVersion.Text = Resources.LoadingStatus;
            lblTotalProjects.Text = Resources.LoadingStatus;
            lblTotalPlans.Text = Resources.LoadingStatus;
            lblAvgPlanProject.Text = Resources.LoadingStatus;
            lblActiveProjects.Text = Resources.LoadingStatus;
            lblActivePlans.Text = Resources.LoadingStatus;

            const string infoUri = "info?os_authType=basic";
            const string projectUri = "project?expand=projects.project.plans.plan.stages&max-result=250&os_authType=basic";

            var generalInfo = await ExecuteRequest<InfoResult>(infoUri);
            if (generalInfo != null)
            {
                lblBuildNumber.Text = generalInfo.BuildNumber;
                lblBuildDate.Text = generalInfo.BuildDate;
                lblState.Text = generalInfo.State;
                lblVersion.Text = generalInfo.Version;
            }

            _projects = await ExecuteRequest<ProjectResult>(projectUri);
            if (_projects != null)
            {
                var totalProjects = _projects.Projects.Size;
                var totalPlans = _projects.Projects.Project.Sum(p => p.Plans.Size);

                var activeProjects = _projects.Projects.Project.Count(p => p.Plans.Plan.Any(l => l.Enabled));
                var activePlans = _projects.Projects.Project.Sum(p => p.Plans.Plan.Count(l => l.Enabled));
                lblTotalProjects.Text = totalProjects.ToString();
                lblTotalProjectsCount.Text = totalProjects.ToString();
                lblTotalPlans.Text = totalPlans.ToString();
                lblTotalPlansCount.Text = totalPlans.ToString();
                lblAvgPlanProject.Text = Math.Round((totalPlans / (decimal)totalProjects), 2).ToString(CultureInfo.InvariantCulture);
                lblActiveProjects.Text = activeProjects.ToString();
                lblActivePlans.Text = activePlans.ToString();

                foreach (var project in _projects.Projects.Project)
                {
                    // Project Name | Project Key | Link | Plan Short Name | Plan Key | Plan Enabled | Plan Link | Average Time In Seconds | Stages | Branches
                    foreach (var plan in project.Plans.Plan)
                    {
                        TimeSpan ts = new TimeSpan(0, 0, Convert.ToInt32(plan.AverageBuildTimeInSeconds));
                        allProjectsGrid.Rows.Add(new object[] { project.Name, project.Key, string.Format("{0}/browse/{1}", _bambooHome, project.Key), plan.ShortName, plan.Key, plan.Enabled, string.Format("{0}/browse/{1}", _bambooHome, plan.Key), string.Format("{0}m {1}s", ts.Minutes, ts.Seconds), plan.Stages.Size, plan.Branches.Size });
                    }
                }
            }

            tabControl.Enabled = true;
        }

        private async Task<T> ExecuteRequest<T>(string uri)
        {
            var handler = new HttpClientHandler { Credentials = _credentials };
            using (var client = new HttpClient(handler))
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var fullUrl = _apiUrl + uri;

                WriteLogMessage(fullUrl);

                using (var response = await client.GetAsync(fullUrl))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (var content = response.Content)
                        {
                            WriteLogMessage(response.StatusCode.ToString());

                            string result = await content.ReadAsStringAsync();
                            var info = JsonConvert.DeserializeObject<T>(result);
                            return info;
                        }
                    }

                    WriteLogMessage(response.StatusCode + " - " + response.ReasonPhrase);
                    return default(T);
                }
            }
        }

        private bool ShowLogin()
        {
            var login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                _apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
                _bambooHome = new Uri(_apiUrl).GetLeftPart(UriPartial.Authority);
                lnkBamboo.Text = _bambooHome;
                _credentials = new NetworkCredential(login.UserName, login.Password);
                lnkUserName.Text = login.UserName;
                return true;
            }

            if (_credentials == null)
            {
                MessageBox.Show(Resources.MustLoginToBamboo, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void lnkUserName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ShowLogin())
            {
                ShowGeneralInfo();

                tabControl.SelectedIndex = 0;
            }
        }

        private void WriteMessage(string message)
        {
            txtConsole.Text += $"{DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss")} - {message}{Environment.NewLine}";
        }

        private void WriteLogMessage(string message)
        {
            InvokeWriteMessage a = WriteMessage;
            txtConsole.Invoke(a, message);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ShowGeneralInfo();
        }

        private void lnkCopyGeneralInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var generalInfo = new StringBuilder();
            generalInfo.AppendLine($"Bamboo: {lnkBamboo.Text}");
            generalInfo.AppendLine($"UserName: {_credentials.UserName}");
            generalInfo.AppendLine($"Current Date: {DateTime.Now.ToShortDateString()}");
            generalInfo.AppendLine();
            generalInfo.AppendLine($"Bamboo Version: {lblVersion.Text}");
            generalInfo.AppendLine($"Build Number: {lblBuildNumber.Text}");
            generalInfo.AppendLine($"Build Date: {lblBuildDate.Text}");
            generalInfo.AppendLine($"State: {lblState.Text}");
            generalInfo.AppendLine();
            generalInfo.AppendLine($"Total Projects: {lblTotalProjects.Text}");
            generalInfo.AppendLine($"Total Plans: {lblTotalPlans.Text}");
            generalInfo.AppendLine($"Avg Plan/Project: {lblAvgPlanProject.Text}");
            generalInfo.AppendLine($"Active Projects: {lblActiveProjects.Text}");
            generalInfo.AppendLine($"Active Plans: {lblActivePlans.Text}");

            Clipboard.SetText(generalInfo.ToString());
            WriteLogMessage("General info copied to clipboard");
        }

        private void lnkBamboo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnkBamboo.Text);
        }

        private void allProjectsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < allProjectsGrid.Rows.Count)
            {
                var potentialUrl = allProjectsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (Uri.IsWellFormedUriString(potentialUrl, UriKind.Absolute))
                {
                    Process.Start(potentialUrl);
                }
            }
        }

        private void lnkExportAllProjects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var allProjects = new StringBuilder();
                allProjects.AppendLine("Project Name,Project Key,Project Link,Plan Short Name,Plan Key,Plan Enabled,Plan Link,Average Build Time,Stages,Branches");

                foreach (DataGridViewRow row in allProjectsGrid.Rows)
                {
                    allProjects.AppendLine(
                        $"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value},{row.Cells[4].Value},{row.Cells[5].Value},{row.Cells[6].Value},{row.Cells[7].Value},{row.Cells[8].Value},{row.Cells[9].Value}");
                }

                File.AppendAllText(saveFileDialog.FileName, allProjects.ToString());

                WriteLogMessage($"File successfully saved to: {saveFileDialog.FileName}");
            }
        }
    }
}