using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientBillWebApp.Models;

namespace ClientBillWebApp.Service.IServices
{
    interface IBillService
    {
        BillModel CreateBill();
        bool DeleteBill(Guid billId);
        BillModel GetBill(Guid billId);
    }
}
