using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class BMP
    {
        [Key]
        public int Id { get; set; }
        public double Sodium { get; set; }
        public double Potassium { get; set; }
        public double Glucose { get; set; }
        public double Calcium { get; set; }
        public double Chloride { get; set; }
        public double Bicarbonate { get; set; }
        public double Creatinine { get; set; }
        public double BUN { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }
    }
}
