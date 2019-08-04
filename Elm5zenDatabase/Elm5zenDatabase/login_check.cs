using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elm5zenDatabase
{
    public class login_check
    {
        
        public int ID { get; set; }
        [Required]
        public string logincheck_username { get; set; }
        [Required]
        public string logincheck_password { get; set; }
        public int logincheck_type { get; set; }
        public string logincheck_name { get; set; }
    }
}
