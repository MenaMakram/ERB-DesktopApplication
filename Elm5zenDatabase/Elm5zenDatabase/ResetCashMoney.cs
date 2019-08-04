using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Elm5zenDatabase
{
    public class ResetCashMoney
    {
        public int ID { get; set; }
        public Decimal ResetMoney { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Invoice")]
        public int? Invoice_ID { get; set; }
        [ForeignKey("Person")]
        public int? Person_ID { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Person Person { get; set; }
    }
}