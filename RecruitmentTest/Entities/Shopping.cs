using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTest.Entities
{
    public class Shopping
    {
        public int id { get; set; }

        [StringLength(145)]
        public string name { get; set; }

        [Column(TypeName = "createdate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public DateTime createdate { get; set; }
    }
}
