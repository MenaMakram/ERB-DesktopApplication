using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Elm5zenDatabase
{
    public class Products:Informations
    {

        public Decimal PriceIn { get; set; }
        public Decimal PriceOutOne { get; set; }
        public Decimal PriceOutAll { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("categories")]
        public int? Categories_ID { get; set; }
        public virtual ICollection<InvoiceProduct> InvoiceProduct { get; set; } = new List<InvoiceProduct>();
        public virtual Categories categories { get; set; } 
    }
}