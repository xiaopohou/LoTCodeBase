﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01.Webuploader.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <returns></returns>
        public ActionResult Upload(string md5,string id, string name, string type, string lastModifiedDate, int size, HttpPostedFileBase file)
        {
            return View();
        }
    }
}