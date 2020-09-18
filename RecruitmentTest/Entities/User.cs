using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTest.Entities
{
    public class User
    {
        public int id { get; set; }

        [StringLength(75)]
        public string username { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(75)]
        public string country { get; set; }

        [StringLength(75)]
        public string city { get; set; }

        [StringLength(12)]
        public string postcode { get; set; }

        [StringLength(125)]
        public string name { get; set; }

        [StringLength(150)]
        public string address { get; set; }
    }
}
