using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elm5zenDatabase
{
     class ERBContext:DbContext
    {
        public ERBContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=Elm5zenDatabase.ERBContext;Integrated Security=True") { }
        public virtual DbSet<Categories> categories { get; set; }
        public virtual DbSet<Payment_Type> PaymentType_ID { get; set; }

        public virtual DbSet<InvoiceProduct> invoice_products { get; set; }
        public virtual DbSet<InvoiceType> invoice_types { get; set; }
        public virtual DbSet<Invoice> invoices { get; set; }
        public virtual DbSet<Person> person { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
       
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ResetCashMoney> RestCashMoneys { get; set; }
        public virtual DbSet<login_check> login_checks { get; set; }
        // public virtual DbSet<Store> Stores { get; set; }
        //public virtual DbSet<SubCategories> SubCategories { get; set; }
    }
}
