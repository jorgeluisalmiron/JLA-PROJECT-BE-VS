using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JLA_Project.Models
{
    [Table("unit_of_measures")]
    public class UnitOfMeasure
    {
        [Key]
        [MaxLength(10)]
        [Column("code")]
        public String Code { get; set; }
        [MaxLength(20)]
        [Column("description")]
        public String Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }

    }
}