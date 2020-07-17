using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Business.Abstract;
using CoreMVC.Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NoDependencyİnjection.Controllers
{
    public class NewsController : Controller
    {

        private INewsService _newsService;
        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }
        public IActionResult Get()
        {
            return View(_newsService.Get());
        }

        public IActionResult ListOf()
        {
            return View(_newsService.GetList());
        }

    }
}