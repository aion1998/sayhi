using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sayhi.Controllers
{
    public class SayHiUserValidateController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            //判断Session是否为空
            if (Session["UserInfo"] == null)
            {
                filterContext.Result = RedirectToAction("Login", "SayHiIndex");


            }
            else
            {
                PersonController._uModel = Session["UserInfo"] as sayHi.Model.sayHi_UserInfo;
            }
        }
    }
}