﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  ClientBillWebApp.Models;

namespace ClientBillWebApp.Service.IServices
{
    interface ICreditCardService
    {
        CreditCardModel CreateCreditCard();
        bool DeleteCreditCard(Guid crediCardId);
        CreditCardModel GetCreditCard(Guid crediCardId);
        bool IsCardActive(Guid creditCardId);
        bool BlockCreditCard(Guid creditCardId);
        bool MakeTransfer(Guid sourceCardId, Guid destinationCardId, double transferAmount);
        bool MakePayment(Guid sourceCardId, Guid orderId);
    }
}
