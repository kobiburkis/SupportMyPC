using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SupportMyPC.Models;

namespace SupportMyPC.Controllers
{
    public class SupportCallsController : Controller
    {
        private IRepository repository;
        public SupportCallsController(IRepository repo)
        {
            repository = repo;
        }
        public ViewResult ListSupportCalls() => View(repository.supportCalls.Where(r => r.SupportCallStatusID == 1));
    }
}
