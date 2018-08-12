using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JLA_Project.Models
{
    [Table("suppliers")]
    public class Supplier : BaseEntity
    {
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
    }
}