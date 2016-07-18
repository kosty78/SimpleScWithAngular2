using System.Web.Mvc;

namespace SimpleSc.Web.Areas.Main
{
    public class MainAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Main";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Main",
                "Main/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "SimpleSc.Web.Areas.Main.Controllers", "SimpleSc.Web.Areas.Main.Models" }
            );
        }
    }
}