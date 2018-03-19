using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sayhi.Areas.FormalSysManagement.Controllers
{
    public class VerificationController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            //string url = Request.Url.AbsolutePath.ToString();
            //判断Session是否为空
            if (Session["AdminInfo"] == null)
            {
                filterContext.Result = RedirectToAction("Login", "ManagingHomePage");
            }
            else
            {
                //if (url== "/FormalSysManagement/ManagingHomePage/Login")
                //{
                //    filterContext.Result = RedirectToAction("Index", "ManagingUserPage");
                //}
                //else
                //{
                //    filterContext.Result = Redirect(url);
                //}
                
            }
        }
    }
}