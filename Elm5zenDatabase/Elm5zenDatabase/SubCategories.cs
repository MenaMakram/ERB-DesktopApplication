using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Elm5zenDatabase
{
     class SubCategories:Informations
    {
        [ForeignKey("categories")]
        public int? categories_ID { get; set; }

        public virtual Categories categories { get; set; }
        public virtual ICollection<Products> Product { get; set; } = new List<Products>();
    }


}