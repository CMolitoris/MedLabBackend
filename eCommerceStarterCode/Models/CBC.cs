using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class CBC
    {
        [Key]
        public int Id { get; set; }
        public double Rbc { get; set; }
        public double Hb { get; set; }
        public double Hct { get; set; }
        public double MCV { get; set; }
        public double MCH { get; set; }
        public double MCHC { get; set; }
        public double RDW { get; set; }
        public double WBC { get; set; }
        public double Neu { get; set; }
        public double Lym { get; set; }
        public double Mon { get; set; }
        public double Eos { get; set; }
        public double Bas { get; set; }
        public double Plt { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }
    }
}
