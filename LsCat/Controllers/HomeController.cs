using LsCat.Areas.Identity.Data;
using LsCat.Helpers;
using LsCat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Policy;
using Microsoft.AspNetCore.Html;


namespace LsCat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly LsCatContext _lsCatContext;


        
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, LsCatContext lsCatContext)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _lsCatContext = lsCatContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //search method

        public async Task<IActionResult> Search(string query)
        {
            var currentUserId = _httpContextAccessor.HttpContext.User.GetUserId();

            // Store the search query in the database
            var search = new SearchHistory { UserID = currentUserId, Query = query, Timestamp = DateTime.Now };
            _lsCatContext.SearchHistory.Add(search);
            await _lsCatContext.SaveChangesAsync();

            return View("Search", query);
        }
    }


}