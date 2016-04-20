using System.Reflection;
using System.Web;
using System.Web.Http;
using Albumprinter.Customers.WebRestService.DAL;
using Newtonsoft.Json;

namespace Albumprinter.Customers.WebRestService
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
  
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling =
                ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Remove(
                GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
