using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sayhi.Areas.sayhiAdmin.Controllers
{
    public class BaseValidateController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            //判断Session是否为空
            if (Session["AdminInfo"] == null)
            {
                filterContext.Result = RedirectToAction("Index", "SayhiMain");
            }
        }
    }
}