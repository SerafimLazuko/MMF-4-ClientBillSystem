using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClientBillWebApp.Models;
using ClientBillWebApp.Data;


namespace ClientBillWebApp.Controllers
{
    public class ClientController : Controller
    {
        private ApplicationDbContext db;

        public ClientController(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index(Guid clientId)
        {
            return View(await db.Clients.FindAsync(clientId));
            //return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> About(Guid clientId)
        {
            return View(await db.Clients.FindAsync(clientId));
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientModel clientModel)
        {
            clientModel.Id = new Guid();
            clientModel.AssosiatedBills = new List<BillModel>();
            clientModel.AssosiatedCards = new List<CreditCardModel>();

            db.Clients.Add(clientModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", clientModel.Id);
        }
    }
}