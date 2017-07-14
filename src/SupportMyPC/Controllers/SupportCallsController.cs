
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SupportMyPC.Models;
using SupportMyPC.Models.ViewModels;
namespace SupportMyPC.Controllers
{
    public class SupportCallsController : Controller
    {
        private IRepository repository;
        public int pageSize = 5;
        public SupportCallsController(IRepository repo)
        {
            repository = repo;
        }

        public ViewResult ListSupportCalls(int page = 1) =>
           View(new SupportCallListViewModel
           {
               supportCalls = repository.supportCalls.
               Where(r => r.SupportCallStatusID == 1).
                            OrderBy(r => r.SupportCallDate).
                            Skip((page - 1) * pageSize).
                            Take(pageSize),
               PagingInfo = new PagingInfo
               {
                   CurrentPage = page,
                   ItemsPerPage = pageSize,
                   TotalItems = repository.supportCalls.Count()
               }
           });
    }
}
