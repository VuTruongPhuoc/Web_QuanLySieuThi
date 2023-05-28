using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class adminsController : Controller
    {
        private JP_QuanLySieuThiEntities1 db = new JP_QuanLySieuThiEntities1();

        // GET: Admin/admins
        public ActionResult Index()
        {
            
            return View(db.admins.ToList());
        }

























        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
