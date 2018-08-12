using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLA_Project.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column("id")]
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }
        [MaxLength(10)]
        [Column("code")]
        [JsonProperty(PropertyName = "code")]
        public String Code { get; set; }
        [Column("name")]
        [JsonProperty(PropertyName = "name")]
        [MaxLength(50)]
        public String Name { get; set; }
        [Column("model")]
        [JsonProperty(PropertyName = "model")]
        [MaxLength(50)]
        public String Model { get; set; }
        [JsonProperty(PropertyName = "mark")]
        [Column("mark")]
        [MaxLength(50)]
        public String Mark { get; set; }
        [JsonProperty(PropertyName = "uom")]
        [Column("uom")]
        [MaxLength(10)]
        public String UnitOfMeasureId { get; set; }
        [Column("description")]
        [JsonProperty(PropertyName = "description")]
        [MaxLength(50)]
        public String Description { get; set; }
        [JsonIgnore]
        public UnitOfMeasure UnitOfMeasure { get; set; }
        [JsonIgnore]
        public ICollection<Supplier> Suppliers { get; set; }

    }
}
