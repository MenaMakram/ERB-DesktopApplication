using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Elm5zenDatabase
{
    public class InvoiceType
    {
        public int ID { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Invoice> invoices { get; set; } = new List<Invoice>();
    }
}