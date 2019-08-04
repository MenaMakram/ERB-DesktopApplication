using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Elm5zenDatabase
{
    public class Invoice
    {
        public int ID { get; set; }
        public DateTime BillDate { get; set; }
        public Decimal TotalCash { get; set; }
        public Decimal TotalBill { get; set; }
        public Decimal TotalReset { get; set; }
        [ForeignKey("Person")]
        public int? Pesron_ID { get; set; }
        [ForeignKey("InvoiceType")]
        public int? InvoiceType_ID { get; set; }
        [ForeignKey("Payment_Type")]
        public int? PaymentType_ID { get; set; }
        [ForeignKey("invoiceTypePrice")]
        public int? invoiceTypePriceID { get; set; }
        public int invoicestatus { get; set; }
        public virtual ICollection<InvoiceProduct> InvoiceProduct { get; set; } = new List<InvoiceProduct>();
        public virtual Payment_Type Payment_Type { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }
        public virtual Person Person { get; set; }
        public virtual invoiceTypePrice invoiceTypePrice { get; set; }
        public virtual ICollection<ResetCashMoney> ResetCashMoney { get; set; } = new List<ResetCashMoney>();

        public virtual ICollection<InvoiceSellPermision> Sells { get; set; } = new List<InvoiceSellPermision>();
        public virtual ICollection<InvoiceSellPermision> PermisionInvoice { get; set; } = new List<InvoiceSellPermision>();
    }
}