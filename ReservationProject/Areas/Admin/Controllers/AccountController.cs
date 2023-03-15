using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using ReservationProject.Areas.Admin.Models;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            var SenderInfos = _accountService.GetById(model.SenderID);
            var ReceiverInfos = _accountService.GetById(model.ReceiverID);

            SenderInfos.Balance -= model.Amount;
            ReceiverInfos.Balance += model.Amount;

            List<Account> accounts = new List<Account>();
            accounts.Add(SenderInfos);
            accounts.Add(ReceiverInfos);

            _accountService.MultiUpdate(accounts);

            return View();
        }
    }
}
