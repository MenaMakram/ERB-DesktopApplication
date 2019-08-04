using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Elm5zenDatabase
{
    public class InvoiceSellPermision
    {
        public int ID { get; set; }
        [ForeignKey("SellsID")]
        public int? InvoiceSellID { get; set; }
        [InverseProperty("Sells")]
        public virtual Invoice SellsID { get; set; }

        [ForeignKey("PermisionIDs")]
        public int? InvoicePermisionID { get; set; }
        [InverseProperty("PermisionInvoice")]
        public virtual Invoice PermisionIDs { get; set; } 
    }
}
