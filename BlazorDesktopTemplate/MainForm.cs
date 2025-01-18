using BlazorDesktopTemplate.lib;
using BlazorDesktopTemplate.src;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDesktopTemplate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private void InitializeWebView()
        {
            var dependency = new DependencyInjection<MainComponent>(webView);
            dependency.Services.AddSingleton(this);
            Ioc.Configure(dependency.Services);
            dependency.Build();
        }

        public void ShowMessage()
        {
            MessageBox.Show("Message text", "Message title");
        }
    }
}
