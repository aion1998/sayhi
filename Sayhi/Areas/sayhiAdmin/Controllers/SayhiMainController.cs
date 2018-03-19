using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sayHi.Model;

namespace Sayhi.Areas.sayhiAdmin.Controllers
{
    public class SayhiMainController : Controller
    {
        /// <summary>
        /// 声明EF操作上下文
        /// </summary>
        sayHiEntities db = GetDBContext.CreateDbContext();
        /// <summary>
        /// 登录主页面
        /// </summary>
        /// <returns></returns>
        // GET: sayhiAdmin/SayhiMain
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 表单提交登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(string name, string pwd)
        {
            var QueryBaseObject =  db.sayhi_AdminInfo.FirstOrDefault(a => a.AdminName == name && a.AdminPwd == pwd);
            if (QueryBaseObject!=null)
            {
                Session["AdminInfo"] = QueryBaseObject;
                return Content(Request.UrlReferrer.ToString());            
                
            }
            else
            {
                string erroMsg;
                var QueryLoginName = db.sayhi_AdminInfo.FirstOrDefault(a => a.AdminName == name);
                if (QueryLoginName != null) { erroMsg = "密码与账号不匹配"; } else { erroMsg = "用户名或密码错误"; }
                return LoginErro(erroMsg);
            }
        }

        /// <summary>
        /// 登录失败页面
        /// </summary>
        /// <param name="ErroMsg"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult LoginErro(string ErroMsg)
        {
            ViewData["ErroMsg"] = ErroMsg;
            return View();
        }
    }
}