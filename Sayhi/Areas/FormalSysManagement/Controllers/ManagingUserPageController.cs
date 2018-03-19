using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sayHi.Model;
using Newtonsoft.Json;

namespace Sayhi.Areas.FormalSysManagement.Controllers
{
    public class ManagingUserPageController : VerificationController
    {
        sayHiEntities DBcontext = GetDBContext.CreateDbContext();
        //
        // GET: /FormalSysManagement/ManagingUserPage/
        public ActionResult Index()
        {
            return View();
        }
        public string GetUserList(int pageSize = 10, int pageIndex = 1)
        {
            List<sayHi_UserInfo> uinfoList = DBcontext.sayHi_UserInfo.Where(a => a.Effect == true).OrderBy(b => b.CreateTime)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();
            string jsonData = JsonConvert.SerializeObject(uinfoList);
            return jsonData;
        }
    }
}