using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndAwaitDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /*----------------------------------------*/
        // this will run sync
        /*----------------------------------------*/

        private void btnSyncStart_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            RunDownloadSync();
            watch.Stop();
            rboxText1.Text += $"Total Execution Time: {watch.ElapsedMilliseconds + Environment.NewLine}";
        }

        private void RunDownloadSync()
        {
            List<string> websiteList = GetWebsites();
            foreach (string siteUrl in websiteList)
            {
                WebsiteDataModel result = DownloadWebsiteString(siteUrl);
                Display(result);
            }
        }

        private void Display(WebsiteDataModel result)
        {
            rboxText1.Text += $"{result.WebsiteUrl} Downloaded : {result.WebsiteData.Length} character long. TimeMilliseconds : {result.TimeMilliseconds}." + Environment.NewLine;
        }

        private WebsiteDataModel DownloadWebsiteString(string websiteUrl)
        {
            WebClient http = new WebClient();
            var innerWatch = System.Diagnostics.Stopwatch.StartNew();
            string data = http.DownloadString(websiteUrl);
            innerWatch.Stop();

            WebsiteDataModel output = new WebsiteDataModel
            {
                WebsiteData = data,
                WebsiteUrl = websiteUrl,
                TimeMilliseconds = innerWatch.ElapsedMilliseconds
            };
            return output;
        }

        private List<string> GetWebsites()
        {
            return new List<string>() {
            "https://www.google.co.in/",
            "https://in.yahoo.com/",
            "https://www.microsoft.com/en-in",
            "https://www.ccn.com/",
            "https://www.codeproject.com/",
            "https://stackoverflow.com/"
            };
        }

        class WebsiteDataModel
        {
            public string WebsiteUrl { get; set; }
            public string WebsiteData { get; set; }
            public long TimeMilliseconds { get; internal set; }
        }

        /*----------------------------------------*/
        //this will run async but one task after other task.
        /*----------------------------------------*/

        private async void btnAsyncStart_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await RunDownloadAsync();
            watch.Stop();
            rboxText1.Text += $"Total Execution Time: {watch.ElapsedMilliseconds + Environment.NewLine}";
        }
        private async Task RunDownloadAsync()
        {
            List<string> websiteList = GetWebsites();
            foreach (string siteUrl in websiteList)
            {
                WebsiteDataModel result = await Task.Run(() => DownloadWebsiteString(siteUrl));
                Display(result);
            }
        }

        /*----------------------------------------*/
        //this will run parallel async.
        /*----------------------------------------*/

        private async void btnPellAsyncStart_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await RunDownloadParallelAsync();
            watch.Stop();
            rboxText1.Text += $"Total Execution Time: {watch.ElapsedMilliseconds + Environment.NewLine}";
        }
        private async Task RunDownloadParallelAsync()
        {
            List<string> websiteList = GetWebsites();
            List<Task<WebsiteDataModel>> taskList = new List<Task<WebsiteDataModel>>();
            foreach (string siteUrl in websiteList)
            {
                taskList.Add(Task.Run(() => DownloadWebsiteString(siteUrl)));
            }
            var result =await Task.WhenAll(taskList);
            foreach (WebsiteDataModel model in result)
            {
                Display(model);
            }
        }

        /*----------------------------------------*/
        //this will run parallel async with inner task.
        /*----------------------------------------*/

        private async void btnParallel1AsyncStart_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await RunDownloadParallel1Async();
            watch.Stop();
            rboxText1.Text += $"Total Execution Time: {watch.ElapsedMilliseconds + Environment.NewLine}";
        }
        private async Task RunDownloadParallel1Async()
        {
            List<string> websiteList = GetWebsites();
            List<Task<WebsiteDataModel>> taskList = new List<Task<WebsiteDataModel>>();
            foreach (string siteUrl in websiteList)
            {
                taskList.Add(Task.Run(() => DownloadWebsiteStringAsync(siteUrl)));
            }
            var result = await Task.WhenAll(taskList);
            foreach (WebsiteDataModel model in result)
            {
                Display(model);
            }
        }
        private async Task<WebsiteDataModel> DownloadWebsiteStringAsync(string websiteUrl)
        {
            WebClient http = new WebClient();
            var innerWatch = System.Diagnostics.Stopwatch.StartNew();
            string data = await http.DownloadStringTaskAsync(websiteUrl);
            innerWatch.Stop();

            WebsiteDataModel output = new WebsiteDataModel
            {
                WebsiteData = data,
                WebsiteUrl = websiteUrl,
                TimeMilliseconds = innerWatch.ElapsedMilliseconds
            };
            return output;
        }
    }
}
