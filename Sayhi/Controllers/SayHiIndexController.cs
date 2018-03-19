using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sayHi.Model;
using Newtonsoft.Json;

namespace Sayhi.Controllers
{
    public class SayHiIndexController : Controller
    {
        sayHiEntities db = GetDBContext.CreateDbContext();
        // GET: SayHiIndex
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 社区
        /// </summary>
        /// <returns></returns>
        public ActionResult Community()
        {
            return View();
        }

        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            return View();
        }

        /// <summary>
        /// Paro
        /// </summary>
        /// <returns></returns>
        public ActionResult Paro()
        {
            return View();
        }

        /// <summary>
        /// 企划
        /// </summary>
        /// <returns></returns>
        public ActionResult Planning()
        {
            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string uName,string uPwd)
        {
            var QueryUInfo = db.sayHi_UserInfo.Where(a => a.Name == uName && a.Pwd == uPwd);
            if (QueryUInfo.ToList().Count()>0)
            {
               Session["UserInfo"] =  QueryUInfo.FirstOrDefault();
                return RedirectToAction("Index", "Person");
            }
            else
            {
                return ErroView("登录失败");
            }
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string uAutograph, string uName, string uPwd)
        {

            var d1 = db.sayHi_UserInfo.Where(a => a.Name == uName);
            if (d1.ToList().Count() > 0)
            {
                return Content("账号已经存在", "text/plain");
            }
            sayHi_UserInfo readlyAdd = new sayHi_UserInfo()
            {
                Name = uName.Trim(),
                Pwd = uPwd,
                Autograph = uAutograph,
                BannerPic = "~/img/banner/banner_1.jpg",
                CreateTime = DateTime.Now,
                Effect = true,
                HeadPortrait = "~img/other/b.jpg",
                Integral = 1,
                Power = 1
            };
            db.sayHi_UserInfo.Add(readlyAdd);
            if (db.SaveChanges() > 0)
            {
                Session["UserInfo"] = readlyAdd;
                return Content("注册成功", "text/plain");
            }
            else
            {
                return Content("注册失败", "text/plain");
            }
        }

        public ActionResult ErroView(string erroMsg)
        {
            switch (erroMsg)
            {
                case "登录失败":ViewData["href"] = "/SayHiIndex/Login";
                    break;
                default:
                    break;
            }
            ViewData["erroMsg"] = erroMsg;
            return View();
        }

    }
}