using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dojodachi.Models;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            Dojo dojodachi = MakeDojos.GetDojoDachi(HttpContext);
            return View(dojodachi);
        }

        [HttpGet("feed")]
        public IActionResult EatFood()
        {
            Dojo dojodachi = MakeDojos.GetDojoDachi(HttpContext);   
            dojodachi.Feed();
            MakeDojos.SetDojoDachi(HttpContext, dojodachi);
            return RedirectToAction("Index");
        }

        [HttpGet("play")]
        public IActionResult PlayDojo()
        {
            Dojo dojodachi = MakeDojos.GetDojoDachi(HttpContext);
            dojodachi.Play();
            MakeDojos.SetDojoDachi(HttpContext, dojodachi);
            return RedirectToAction("Index");
        }

        [HttpGet("work")]
        public IActionResult WerkWerk()
        {
            Dojo dojodachi = MakeDojos.GetDojoDachi(HttpContext);
            dojodachi.Work();
            MakeDojos.SetDojoDachi(HttpContext, dojodachi);
            return RedirectToAction("Index");
        }

        [HttpGet("sleep")]
        public IActionResult SleepingDojo()
        {
            Dojo dojodachi = MakeDojos.GetDojoDachi(HttpContext);
            dojodachi.Sleep();
            MakeDojos.SetDojoDachi(HttpContext, dojodachi);
            return RedirectToAction("Index");
        }

        [HttpGet("reset")]
        public IActionResult NewGame()
        {
            Dojo dojodachi = MakeDojos.GetDojoDachi(HttpContext);
            dojodachi.Reset();
            MakeDojos.SetDojoDachi(HttpContext, dojodachi);
            return RedirectToAction("Index");
        }
    }
}
