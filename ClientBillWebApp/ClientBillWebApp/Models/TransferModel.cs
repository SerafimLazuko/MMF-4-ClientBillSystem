using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBillWebApp.Models
{
    public class TransferModel
    {
        public Guid TransferId { get; set; }
        public Guid DestinationBillId { get; set; }
        public Guid SourceBillId { get; set; }
        public double TransferAmount { get; set; }
        public DateTime DateTime { get; set; }
    }
}
