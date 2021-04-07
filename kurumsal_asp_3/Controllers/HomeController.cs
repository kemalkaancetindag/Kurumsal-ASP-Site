using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kurumsal_asp_3.Models;

namespace kurumsal_asp_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static string cImgUrl = "https://via.placeholder.com/1280x400.png";
        private static string sImgUrl = "https://via.placeholder.com/400x300.png";
        private static string he1 = "Start Today";
        private static string he2 = "New Beginings";
        private static string txt1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam sit amet interdum nisl. Vestibulum tempor nibh ac felis molestie convallis a non diam. Morbi id magna venenatis, euismod augue sit amet, blandit odio. Maecenas luctus, augue at euismod sagittis, sem sapien gravida libero, vel dapibus lorem erat sed velit. Mauris in ligula in mauris dapibus commodo. Suspendisse potenti. Vivamus gravida nec augue nec molestie. Vivamus ac egestas eros, sed hendrerit purus. Proin sit amet vehicula urna. Suspendisse sit amet urna vel magna mollis interdum a in neque. Aliquam euismod magna in massa mollis fringilla sed at arcu.";
        private static string txt2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam sit amet interdum nisl. Vestibulum tempor nibh ac felis molestie convallis a non diam. Morbi id magna venenatis, euismod augue sit amet, blandit odio. Maecenas luctus, augue at euismod sagittis, sem sapien gravida libero, vel dapibus lorem erat sed velit. Mauris in ligula in mauris dapibus commodo. Suspendisse potenti. Vivamus gravida nec augue nec molestie. Vivamus ac egestas eros, sed hendrerit purus. Proin sit amet vehicula urna. Suspendisse sit amet urna vel magna mollis interdum a in neque. Aliquam euismod magna in massa mollis fringilla sed at arcu.";


        HomeModel model = new HomeModel
        {
            carouserImgUrl = cImgUrl,
            secondImgUrl = sImgUrl,
            header1 = he1,
            header2 = he2,
            text1 = txt1,
            text2 = txt2
        };

        public IActionResult Index()
        {
            ViewData["Message"] = model;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
