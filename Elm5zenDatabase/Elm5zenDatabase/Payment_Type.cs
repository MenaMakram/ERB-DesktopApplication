using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elm5zenDatabase
{
    [Table("Payment_Type")]
   public class Payment_Type
    {
        public int ID { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
