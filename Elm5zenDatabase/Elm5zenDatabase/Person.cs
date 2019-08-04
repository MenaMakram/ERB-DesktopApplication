using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Elm5zenDatabase
{
    public class Person:Informations
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public Decimal AccountMoney { get; set; }


        public virtual ICollection<Invoice> Invoices { get; set; }= new List<Invoice>();
        public virtual ICollection<ResetCashMoney> ResetCashMoney { get; set; } = new List<ResetCashMoney>();
        [ForeignKey("PersonType")]
        public int? PersonType_ID { get; set; }
        public virtual PersonType PersonType { get; set; }
    }
}