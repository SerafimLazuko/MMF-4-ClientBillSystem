using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBillWebApp.Models
{
    public class ClientModel
    {
        public string Name { get; set; }

        public Guid Id { get; set; }
        
        public List<CreditCardModel> AssosiatedCards { get; set; } 

        public List<BillModel> AssosiatedBills { get; set; }

    }
}
