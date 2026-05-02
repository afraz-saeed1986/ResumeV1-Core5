using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Page;
using Resume.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Constructor
        private readonly IThingIDoService _thingIDoService;

        public HomeController(IThingIDoService thingIDoService)
        {
                _thingIDoService = thingIDoService; 
        }
        #endregion

        public IActionResult Index()
        {
            IndexPageViewModel model = new IndexPageViewModel()
            {
                ThingIDoList = _thingIDoService.GetAllThingIDoForIndex()
            };


            return View(model);
        }
    }
}
