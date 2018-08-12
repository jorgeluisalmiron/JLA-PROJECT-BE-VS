namespace JLA_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.address",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        street = c.String(maxLength: 50),
                        number = c.String(maxLength: 10),
                        floor = c.String(maxLength: 2),
                        apartment = c.String(maxLength: 2),
                        comments = c.String(maxLength: 50),
                        city = c.String(maxLength: 50),
                        state = c.String(maxLength: 50),
                        country = c.String(maxLength: 50),
                        zip = c.String(maxLength: 10),
                        Client_Id = c.Long(),
                        Supplier_Id = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.clients", t => t.Client_Id)
                .ForeignKey("dbo.suppliers", t => t.Supplier_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Supplier_Id);
            
            CreateTable(
                "dbo.clients",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        first_name = c.String(maxLength: 50),
                        last_name = c.String(maxLength: 50),
                        company = c.String(maxLength: 50),
                        doc_type = c.String(maxLength: 10),
                        doc_number = c.String(maxLength: 20),
                        tin = c.String(maxLength: 20),
                        phone = c.String(maxLength: 50),
                        mobile = c.String(maxLength: 50),
                        email = c.String(maxLength: 50),
                        comments = c.String(maxLength: 100),
                        created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        code = c.String(maxLength: 10),
                        name = c.String(maxLength: 50),
                        model = c.String(maxLength: 50),
                        mark = c.String(maxLength: 50),
                        uom = c.String(nullable: false, maxLength: 10),
                        description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.unit_of_measures", t => t.uom, cascadeDelete: true)
                .Index(t => t.uom);
            
            CreateTable(
                "dbo.suppliers",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        first_name = c.String(maxLength: 50),
                        last_name = c.String(maxLength: 50),
                        company = c.String(maxLength: 50),
                        doc_type = c.String(maxLength: 10),
                        doc_number = c.String(maxLength: 20),
                        tin = c.String(maxLength: 20),
                        phone = c.String(maxLength: 50),
                        mobile = c.String(maxLength: 50),
                        email = c.String(maxLength: 50),
                        comments = c.String(maxLength: 100),
                        created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.unit_of_measures",
                c => new
                    {
                        code = c.String(nullable: false, maxLength: 10),
                        description = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.code);
            
            CreateTable(
                "dbo.products_suppliers",
                c => new
                    {
                        product_id = c.Long(nullable: false),
                        supplier_id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.product_id, t.supplier_id })
                .ForeignKey("dbo.products", t => t.product_id, cascadeDelete: true)
                .ForeignKey("dbo.suppliers", t => t.supplier_id, cascadeDelete: true)
                .Index(t => t.product_id)
                .Index(t => t.supplier_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "uom", "dbo.unit_of_measures");
            DropForeignKey("dbo.products_suppliers", "supplier_id", "dbo.suppliers");
            DropForeignKey("dbo.products_suppliers", "product_id", "dbo.products");
            DropForeignKey("dbo.address", "Supplier_Id", "dbo.suppliers");
            DropForeignKey("dbo.address", "Client_Id", "dbo.clients");
            DropIndex("dbo.products_suppliers", new[] { "supplier_id" });
            DropIndex("dbo.products_suppliers", new[] { "product_id" });
            DropIndex("dbo.products", new[] { "uom" });
            DropIndex("dbo.address", new[] { "Supplier_Id" });
            DropIndex("dbo.address", new[] { "Client_Id" });
            DropTable("dbo.products_suppliers");
            DropTable("dbo.unit_of_measures");
            DropTable("dbo.suppliers");
            DropTable("dbo.products");
            DropTable("dbo.clients");
            DropTable("dbo.address");
        }
    }
}
