﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClientBillWebApp.Controllers
{
    public class CreditCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}