using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NestedViewModel.Models;

namespace NestedViewModel.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new HomeViewModel());
        }

        public ActionResult UsingEditorFor()
        {
            return View(new HomeViewModel());
        }

        public ActionResult UsingSharedEditorTemplates()
        {
            return View(new HomeViewModel());
        }
    }
}
