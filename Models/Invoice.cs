using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PivotTableinMVCCore.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceNumber { get; set; }
        public double Amount { get; set; }
        public string CostCategory { get; set; }
        public string Period { get; set; }

        public string Resource { get; set; }
    }
}

