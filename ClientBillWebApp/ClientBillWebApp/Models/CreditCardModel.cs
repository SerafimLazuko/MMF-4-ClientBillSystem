﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBillWebApp.Models
{
    public class CreditCardModel
    {
        public double Balance { get; set; }
        public Guid AssosiatedBillId { get; set; }
        public Guid HolderId { get; set; }
        public PayHistory PayHistory { get; set; }
    }
}
