using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientBillWebApp.Models;
using ClientBillWebApp.Service.IServices;

namespace ClientBillWebApp.Service.Services
{
    public class CreditCardService: ICreditCardService
    {
        public CreditCardModel CreateCreditCard()
        {
            throw new NotImplementedException();
        }

        public bool DeleteCreditCard(Guid creditCardId)
        {
            throw new NotImplementedException();
        }

        public CreditCardModel GetCreditCard(Guid creditCardId)
        {
            throw new NotImplementedException();
        }

        public bool IsCardActive(Guid creditCardId)
        {
            throw new NotImplementedException();
        }

        public bool BlockCreditCard(Guid creditCardId)
        {
            throw new NotImplementedException();
        }

        public bool MakeTransfer(Guid sourceCardId, Guid destinationCardId, double transferAmount)
        {
            throw new NotImplementedException();
        }

        public bool PayOrder(Guid sourceCardId, Guid orderId, double orderCost)
        {
            throw new NotImplementedException();
        }

        public bool CancelBill(Guid creditCardId, Guid billId)
        {
            throw new NotImplementedException();
        }

        public double PrintBalance(Guid creditCardId)
        {
            throw new NotImplementedException();
        }
    }
}
