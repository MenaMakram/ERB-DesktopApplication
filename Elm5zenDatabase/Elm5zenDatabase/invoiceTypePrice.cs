using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elm5zenDatabase
{
    public class invoiceTypePrice
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Invoice> invoices { get; set; } = new List<Invoice>();
    }
}
