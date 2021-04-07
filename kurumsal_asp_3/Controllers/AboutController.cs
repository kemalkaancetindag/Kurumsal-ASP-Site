using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kurumsal_asp_3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace kurumsal_asp_3.Controllers
{
    public class AboutController : Controller
    {
        private static string aText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean tincidunt eros aliquam nisi tristique, at viverra dui rutrum. Nulla lobortis, sapien sit amet finibus tempus, urna felis vestibulum risus, et tincidunt sapien ipsum et magna. Sed lacus nisi, dignissim nec risus eleifend, feugiat fermentum est. In molestie facilisis massa eu tincidunt. Donec orci turpis, congue in enim eu, condimentum finibus leo. Vestibulum vitae congue orci. Cras molestie mattis consequat. Etiam at justo tristique, dapibus sapien vel, congue est. Cras lobortis viverra sapien dictum egestas. Vivamus aliquet massa a ante semper, porttitor consequat nisl molestie. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In nisl massa, placerat non porta sed, blandit at enim. Vestibulum ex velit, euismod at ultricies et, pellentesque eu odio. Nullam in sapien risus. Aliquam erat volutpat.";
        // GET: /<controller>/
        public IActionResult About()
        {
            AboutModel model = new AboutModel
            {
                aboutText = aText
            };

            ViewData["Message"] = model;
            return View();
        }
    }
}
