using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using Db.Model;
using Db.Repository;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            //veri cekme
            DownloadRepository dr=new DownloadRepository();
            List<Download> list= dr.List();
            
            return View(list);
        }

        [Route("download-detail")]
        public IActionResult Detail()
        {
            ViewData["Message"] = "Download detail page";

            return View();
        }

        [Route("download")]
        public IActionResult Download()
        {
            ViewData["Message"] = "Download page";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
