using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Elm5zenDatabase
{
    public class Categories:Informations
    {

        public virtual ICollection<Products> Products { get; set; } = new List<Products>();
    }
}