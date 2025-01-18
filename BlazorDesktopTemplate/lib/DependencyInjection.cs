using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDesktopTemplate.lib
{
    public class DependencyInjection<TComponent>(BlazorWebView webView) where TComponent: IComponent
    {
        ServiceCollection services = new ServiceCollection();

        public ServiceCollection Services => services;
        public void Build()
        {
            services.AddWindowsFormsBlazorWebView();
            webView.HostPage = "wwwroot\\index.html";
            webView.Services = services.BuildServiceProvider();
            webView.RootComponents.Add<TComponent>("#app");
        }
    }
}
