using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;

namespace SugarsqlTest.Controllers
{
    public class HomeController : Controller
    {
        StudentBLL StudentBLL = new StudentBLL();
        public ActionResult Index()
        {
            List<Student> list = StudentBLL.SelectAll();
            ViewBag.list = list;
            return View();
        }
        public bool Insert()
        {
            return StudentBLL.Insert();
        }
        public bool Update()
        {
            return StudentBLL.Update();
        }
        public bool Delete()
        {
            return StudentBLL.Delete();
        }

    }
}