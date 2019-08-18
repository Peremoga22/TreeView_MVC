using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppConvertFolderDataToJasonFormat.Controllers
{
    public class TreeNodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}