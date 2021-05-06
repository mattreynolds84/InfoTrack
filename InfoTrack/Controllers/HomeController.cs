using InfoTrack.BusinessLogic.Services;
using InfoTrack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace InfoTrack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGoogleSearchService _googleSearchService;
        public HomeController(ILogger<HomeController> logger, IGoogleSearchService googleSearchService)
        {
            _logger = logger;
            _googleSearchService = googleSearchService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> SearchSEO(string keywords, string uri)
        {
            try{
                var results = await _googleSearchService.Search(keywords, uri);
                return Json(results);
            }
            catch (Exception ex) {
                _logger.LogError(ex.Message);
                return Json(new List<int>());
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
