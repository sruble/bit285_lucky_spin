using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LuckySpin.Controllers
{
  
    public class SpinnerController : Controller
    {
        //[Route("{Spinner}/{Index}/{luck(1,10)}")]
        //GET: /<controller>/
        Lucky7 lucky = new Lucky7();
        
        public IActionResult Index(int luck)
        {

         
            return new ContentResult { Content = lucky.Output(luck) };
            //return View();      

        }

        //public IActionResult luck(int id = 0)
        //{
        //    return new ContentResult { Content = "Spinning" };
        //}
    }
}
