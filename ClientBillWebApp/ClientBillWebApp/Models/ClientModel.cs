using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBillWebApp.Models
{
    public class ClientModel
    {
        public string Name { get; set; }

        public Guid ClientId { get; set; }
        
        public List<Guid> AssosiatedCards { get; set; } 

        public List<Guid> AssosiatedBills { get; set; }

    }
}
