using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Elm5zenDatabase
{
    public class InvoiceProduct
    {
        public int ID { get; set; }
        
        public int Quantity { get; set; }
        public string SerialNumber { get; set; }
        [ForeignKey("Invoice")]
        public int? Invoice_ID { get; set; }
        [ForeignKey("Products")]
        public int? Product_ID { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Products Products { get; set; }
    }

}