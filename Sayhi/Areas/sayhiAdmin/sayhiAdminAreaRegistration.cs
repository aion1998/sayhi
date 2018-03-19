using System.Web.Mvc;

namespace Sayhi.Areas.sayhiAdmin
{
    public class sayhiAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "sayhiAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "sayhiAdmin_default",
                "sayhiAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}