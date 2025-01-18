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
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddSingleton(this);
            webView.HostPage = "wwwroot\\index.html";
            webView.Services = services.BuildServiceProvider();
            webView.RootComponents.Add<MainComponent>("#app");
        }

        public void ShowMessage()
        {
            MessageBox.Show("Message text", "Message title");
        }
    }
}
