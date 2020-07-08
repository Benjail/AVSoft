using AVSoft.Data;
using AVSoft.Data.Models;
using AVSoft.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVSoft.Controllers
{   [Route("Home")]
    public class HomeController:Controller
    {
        private IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet("getall")]
        public IActionResult GetAllCounters()
        {
            var allItems = Json(repository.GetAll());
            return allItems;
        }
        [Route("Request")]
        public ViewResult Index()
        {
            return View();
        }
    }
}