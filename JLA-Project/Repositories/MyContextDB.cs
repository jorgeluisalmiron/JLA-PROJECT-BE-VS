namespace JLA_Project.Repositories
{
    using JLA_Project.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContextDB : DbContext
    {
        public MyContextDB()
            : base("name=MyContextDB")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                        .HasMany<Supplier>(s => s.Suppliers)
                        .WithMany(p => p.Products)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("product_id");
                            cs.MapRightKey("supplier_id");
                            cs.ToTable("products_suppliers");
                        });
            //one-to-many 
            modelBuilder.Entity<UnitOfMeasure>()
                     .HasMany<Product>(g => g.Products)
                     .WithRequired(s => s.UnitOfMeasure)
                     .HasForeignKey<String>(s => s.UnitOfMeasureId);

            //one-to-many 
            /*   modelBuilder.Entity<Supplier>()
                .HasMany(c => c.Addresses)
                .WithOptional()
                .WillCascadeOnDelete();
                */

        }
    }

}