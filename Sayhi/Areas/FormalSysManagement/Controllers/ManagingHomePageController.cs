using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sayHi.Model;

namespace Sayhi.Areas.FormalSysManagement.Controllers
{
    public class ManagingHomePageController : Controller
    {

        sayHiEntities DBcontext = GetDBContext.CreateDbContext();
        #region 视图
        //public ActionResult Index()
        //{
        //    return Login();
        //}

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string name,string pwd)
        {
            sayhi_AdminInfo obj = DBcontext.sayhi_AdminInfo.FirstOrDefault(a => a.AdminName == name && a.AdminPwd == pwd);
            if (obj!=null)
            {
                Session["AdminInfo"] = obj;
                return RedirectToAction("Index","ManagingUserPage");
            }
            return Content("<script>alert('登录失败','登录失败,用户名或密码错误')</script>", "text/javascript");
        }
        
        #endregion

        #region 数据

        #endregion
    }
}