using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClientBillWebApp.Data;
using ClientBillWebApp.Models;

namespace ClientBillWebApp.Controllers
{
    public class TransferController : Controller
    {
        private ApplicationDbContext context;

        public TransferController(ApplicationDbContext appContext)
        {
            context = appContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Transfer()
        {
            TransferModel model = new TransferModel();
            model.DateTime = DateTime.UtcNow;
            model.Id = new Guid();
            model.TransferAmount = ViewBag.TransferAmount;
            model.SourceBillId = ViewBag.SourceBillId;
            model.DestinationBillId = ViewBag.DestinationBillId;

            await context.Transfers.AddAsync(model);
            await context.SaveChangesAsync();

            return View(model);
        }
    }
}