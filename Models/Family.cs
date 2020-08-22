using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDataGridForSaad.Models
{
    public class Family
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Kids { get; set; }
        public string House { get; set; }
        public string Parents { get; set; }
    }
}
