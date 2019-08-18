﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAppConvertFolderDataToJasonFormat.Services.Interfaces;

namespace WebAppConvertFolderDataToJasonFormat.Controllers
{
    public class TreeNodeController : Controller
    {
        private readonly IFileService _fileService;

        public TreeNodeController(IFileService fileService)
        {
            _fileService = fileService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string folder)
        {
            var res = _fileService.OutPutInfo(folder);
            var serealizeResult = JsonConvert.SerializeObject(res, Formatting.Indented);
            return Content(serealizeResult);
        }
    }
}