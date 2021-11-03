using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class CBCList
    {
        [Column(Order = 0), Key, ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [Column(Order = 1), Key, ForeignKey("CBC")]
        public int CBCId { get; set; }
        public CBC CBC { get; set; }
    }
}
