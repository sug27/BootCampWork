using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{ 
    public class YoloController : Controller
    {
        // GET: Yolo
       [HttpGet]
        public ViewResult Index()
        {
         return View();
        }
        [HttpPost]
        public ViewResult Index(int data)
        {
            data = int.Parse(Request.Form["id"].ToString());
            return View("SuccessIndex",data);
        }
    }
}