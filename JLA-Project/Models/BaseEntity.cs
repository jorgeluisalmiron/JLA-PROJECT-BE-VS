using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JLA_Project.Models
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("first_name")]
        [MinLength(1)]
        [MaxLength(50)]
        public String FirstName { get; set; }
        [Column("last_name")]
        [MinLength(1)]
        [MaxLength(50)]
        public String LastName { get; set; }
        [Column("company")]
        [MaxLength(50)]
        public String CompanyName { get; set; }
        [Column("doc_type")]
        [MaxLength(10)]
        public String DocType { get; set; }
        [Column("doc_number")]
        [MaxLength(20)]
        public String DocNumber { get; set; }
        [Column("tin")]
        [MaxLength(20)]
        public String TaxIdentNumber { get; set; }
        [Column("phone")]
        [MaxLength(50)]
        public String Phone { get; set; }
        [Column("mobile")]
        [MaxLength(50)]
        public String MobilePhone { get; set; }
        [Column("email")]
        [MaxLength(50)]
        public String Email { get; set; }
        [Column("comments")]
        [MaxLength(100)]
        public String Comments { get; set; }
        [Column("created")]
        public DateTime Created { get; set; } = DateTime.Now;
        public virtual ICollection<Address> Addresses { get; set; }
    }
}