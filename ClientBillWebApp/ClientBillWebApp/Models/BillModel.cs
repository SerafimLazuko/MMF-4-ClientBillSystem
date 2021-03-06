﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBillWebApp.Models
{
    public class BillModel
    {
        public Guid Id { get; set; }
        public Guid HolderGuid { get; set; }
        public List<CreditCardModel> AssosiatedCards { get; set; }
        public bool IsActive { get; set; }
        public double Balance { get; set; }
    }
}
