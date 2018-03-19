using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sayHi.Model;
using Newtonsoft.Json;

namespace Sayhi.Areas.FormalSysManagement.Controllers
{
    public class ManagementerController : VerificationController
    {
        sayHiEntities DBcontext = GetDBContext.CreateDbContext();
        // GET: FormalSysManagement/Managementer
        public ActionResult Index()
        {
            return View();
        }

        public string GetAdminList(int pageSize = 10, int pageIndex = 1)
        {
            List<sayhi_AdminInfo> uinfoList = DBcontext.sayhi_AdminInfo.Where(a => a.Effect == true).OrderBy(b => b.CreateTime)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();
            string jsonData = JsonConvert.SerializeObject(uinfoList);
            return jsonData;
        }

    }
}