using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDataGridForSaad.Models
{
    public class CustomerTB
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string extn { get; set; }
        public string start_date { get; set; }
        public string salary { get; set; }

        
        public virtual Family family { get; set; }
    }
}
