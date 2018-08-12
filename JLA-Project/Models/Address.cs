using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JLA_Project.Models
{
    [Table("address")]
    public class Address
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("street")]
        [MaxLength(50)]
        public String Street { get; set; }
        [Column("number")]
        [MaxLength(10)]
        public String Number { get; set; }
        [Column("floor")]
        [MaxLength(2)]
        public String Floor { get; set; }
        [Column("apartment")]
        [MaxLength(2)]
        public String Apartment { get; set; }
        [Column("comments")]
        [MaxLength(50)]
        public String Comments { get; set; }
        [Column("city")]
        [MaxLength(50)]
        public String City { get; set; }
        [Column("state")]
        [MaxLength(50)]
        public String State { get; set; }
        [Column("country")]
        [MaxLength(50)]
        public String Country { get; set; }
        [Column("zip")]
        [MaxLength(10)]
        public String Zip { get; set; }
        //public long RelationId { get; set; }

    }
}