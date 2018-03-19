using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sayHi.Model;

namespace Sayhi.Controllers
{
    public class PersonController : SayHiUserValidateController
    {
        /// <summary>
        /// 用户数据模型
        /// </summary>
        public static sayHi_UserInfo _uModel { get; set; }
        // GET: Person
        public ActionResult Index()
        {
            
            _uModel = Session["UserInfo"] as sayHi_UserInfo;
            return View(_uModel);
        }
        public ActionResult overUserInfo()
        {
            Session["UserInfo"] = null;
            return RedirectToAction("Index", "SayHiIndex");
        }

        public ActionResult MenuList()
        {
            ViewData["uName"] = _uModel.Name;
            return View();
        }
    }
}