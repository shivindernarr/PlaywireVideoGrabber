using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using PlaywireVideoGrabber.Enums;
using PlaywireVideoGrabber.Models;
using PlaywireVideoGrabber.Utilities;

namespace PlaywireVideoGrabber
{
    public partial class Linker : Form
    {
        private List<SerialInfo> _serials = Constants.PredefinedSerials;
        private readonly Stopwatch _stopwatch;
        private CancellationTokenSource _cancellationTokenSource;
        private PlaywireVideo _videoQuality;
        private readonly FileUtility _fileUtillity;
        private const string ConfigFileName = "config.xml";
        private string _customLink = string.Empty;
        private bool _allChecked = true;

        public Linker()
        {
            InitializeComponent();            
            BackgroundLinker.DoWork += GetLinks;
            BackgroundLinker.RunWorkerCompleted += CompletedWork;
            BackgroundLinker.ProgressChanged += WorkProgressChanged;            
            _stopwatch = new Stopwatch();
            _cancellationTokenSource = new CancellationTokenSource();
            _fileUtillity = new FileUtility();
            _videoQuality = PlaywireVideo.Standard;
            txtTemplateDateFormat.Text = Constants.DateFormat;
            txtTemplateRegex.Text = Constants.YoDesiPattern;
            txtTemplateLinkBaseUrl.Text = Constants.YoDesiBaseUrl;
            GetSerialConfig();  
            UpdateSerials();        
        }

        private void UpdateSerials()
        {
            CheckedSerials.Items.Clear();
            _serials.ForEach(serial => CheckedSerials.Items.Add($"{serial.Name} - {serial.Template}", serial.Active));
        }

        private void CreateSerialConfig()
        {
            _fileUtillity.XmlSerialize(ConfigFileName, _serials);
        }

        private void GetSerialConfig()
        {
            if (File.Exists(ConfigFileName))
            {
                _serials = _fileUtillity.XmlDeserialize<List<SerialInfo>>(ConfigFileName);
                _serials.ForEach(x => x.VideoLinks = new List<string>());
            }
        }

        private void WorkProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LinkerProgress.Value = e.ProgressPercentage;
        }

        private void CompletedWork(object sender, RunWorkerCompletedEventArgs e)
        {
            _stopwatch.Stop();
            StartButton.Enabled = true;
            StartButton.Text = @"Start";
            DisplayLinks();            
            LinkerStatusInfo.Text = _cancellationTokenSource.IsCancellationRequested ? @"Operation cancelled." : $"Done in {_stopwatch.ElapsedMilliseconds/1000f} seconds";
        }

        private void DisplayLinks()
        {
            if (checkCustomUrl.Checked)
            {
                TextOutput.AppendText(_customLink);
            }
            else
            {
                foreach (var serial in _serials.Where(x => x.Active))
                {
                    TextOutput.AppendText($"-{serial.Name}\n");
                    var orderedLinks = serial.VideoLinks?.ToList();
                    orderedLinks?.ForEach(link =>
                    {
                        TextOutput.AppendText($"{link}\n");
                    });
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!BackgroundLinker.IsBusy)
            {
                _stopwatch.Start();
                _cancellationTokenSource = new CancellationTokenSource();
                TextOutput.Text = string.Empty;
                LinkerProgress.Value = 0;
                LinkerStatusInfo.Text = @"Processing...";
                BackgroundLinker.RunWorkerAsync();
                StartButton.Text = @"Stop";
            }
            else
            {
                _cancellationTokenSource.Cancel();
                BackgroundLinker.CancelAsync();
                StartButton.Enabled = false;                
            }
        }

        private void GetLinks(object sender, DoWorkEventArgs e)
        {            
            var urlUtility = new UrlUtility(new NetClient(new HttpClient()));
            PlaywireUtility playwireUtility = new PlaywireUtility(urlUtility);
            if (checkCustomUrl.Checked)
            {
                urlUtility.NetClient = new NetClient(GetHttpClientWithHeaders(TxtCustomUrlHeaders.Text));
                _customLink = playwireUtility.GetVideoLink(txtCustomUrl.Text, _videoQuality).Result;                
            }
            else
            {
                var linker = new LinkCrawler(playwireUtility, urlUtility, _serials);
                _serials = linker.GetLinks(DateSelector.Value, BackgroundLinker, _videoQuality,
                    _cancellationTokenSource.Token);
            }
        }

        private HttpClient GetHttpClientWithHeaders(string headers)
        {
            var httpClient = new HttpClient();
            if (headers.Contains("="))
            {
                var headerList = headers.Split(';');
                foreach (var headerPair in headerList.Select(header => header.Split('=')))
                {
                    httpClient.DefaultRequestHeaders.Add(headerPair[0], headerPair[1]);
                }
            }

            return httpClient;
        }

        private void VideoQualityChanged(object sender, EventArgs e)
        {
            if (RadioBtnStandard.Checked)
            {
                _videoQuality = PlaywireVideo.Standard;
            }
            else if (RadioBtnHd.Checked)
            {
                _videoQuality = PlaywireVideo.Hd;
            }
        }

        private void TextOutput_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void CheckedSerials_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            _serials[e.Index].Active = (e.NewValue == CheckState.Checked);
            FillTemplateFields(_serials[e.Index]);
        }

        private void FillTemplateFields(SerialInfo serial)
        {
            TxtSerialName.Text = serial.Name;
            TxtSerialTemplate.Text = serial.Template;
            LinkSize.Value = serial.NumberOfLinks;
            TxtCustomHeaders.Text = serial.CustomHeaders;
            txtTemplateLinkBaseUrl.Text = serial.LinkBaseUrl;
            txtTemplateRegex.Text = serial.LinkSubUrlRegex;
            txtTemplateDateFormat.Text = serial.DateFormat;
        }

        private void BtnRemoveSerial_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show(@"Do you want to remove serials?", @"Delete", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                _serials = _serials.Where(x => x.Active).ToList();                
                UpdateSerials();                
            }
        }

        private void BtnAddSerial_Click(object sender, EventArgs e)
        {
            var serial = new SerialInfo
            {
                Active = true,
                Name = TxtSerialName.Text.Trim(),
                Template = TxtSerialTemplate.Text.Trim(),
                NumberOfLinks = (int) LinkSize.Value,
                DateFormat = txtTemplateDateFormat.Text,
                LinkSubUrlRegex = txtTemplateRegex.Text,
                LinkBaseUrl = txtTemplateLinkBaseUrl.Text,
                CustomHeaders = TxtCustomHeaders.Text
            };

            if (string.IsNullOrEmpty(serial.Name) || string.IsNullOrEmpty(serial.Template))
            {
                MessageBox.Show(@"Empty template name or url");
            }
            else if (_serials.Any(x => x.Name == serial.Name))
            {
                var value = _serials.First(x => x.Name == serial.Name);
                _serials.Remove(value);
                _serials.Add(serial);
                UpdateSerials();
                MessageBox.Show(@"Template updated.");
            }
            else
            {                
                _serials.Add(serial);
                UpdateSerials();                
            }
        }

        private void Linker_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateSerialConfig();
        }

        private void checkCustomUrl_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomUrl.Enabled = checkCustomUrl.Checked;
            TxtCustomUrlHeaders.Enabled = txtCustomUrl.Enabled;
        }

        private void BtnCheckUncheck_Click(object sender, EventArgs e)
        {
            _allChecked = !_allChecked;
            _serials.ForEach(x => x.Active = _allChecked);
            UpdateSerials();            
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
            
               {0} is a placeholder for date format in template.
               {0} is a placeholder for date suffix in date format.
               Custom headers format is: 'header name = header value; header name = header value'
               Custom headers and template values are separated by semicolon ';'
               Template url is followed by regex to get to link url.

            ", @"Help");
        }
    }
}