using Microsoft.AspNetCore.Mvc;
using System;
using SupportMyPC.Models;
using System.Linq;

namespace SupportMyPC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "בוקר טוב" : "צהריים טובים";
            return View ("MyView");
        }
        [HttpGet]
        public ViewResult SupportForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SupportSubmit(SupportCall supportResponse)
        {
            if (ModelState.IsValid)
            {
                supportResponse.SupportCallId = 11111;
                if (supportResponse.ProblemMachineID == 1)
                    supportResponse.ProblemMachine = "מחשב נייח";
                else
                    supportResponse.ProblemMachine = "מחשב נייד";
                supportResponse.RegisteredCust = false;
                supportResponse.SupportCallDate = DateTime.Now.ToString();
                supportResponse.SupportCallStatusID = 1;
                supportResponse.SupportCallStatus = "פתוחה";
                Repository.AddSupportCall(supportResponse);
                return View("Thanks", supportResponse);
            }
            else
                return View("SupportForm");


        }
        public ViewResult ListSupportCalls()
        {
            return View(Repository.SupportCalls.Where(r => r.SupportCallStatusID == 1));
        }
    }
}
