namespace JLA_Project.Migrations
{
    using JLA_Project.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JLA_Project.Repositories.MyContextDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JLA_Project.Repositories.MyContextDB context)
        {
            this.AddClients(context);
            this.AddUnitOfMeasures(context);
            this.AddProducts(context);

        }

        private void AddUnitOfMeasures(JLA_Project.Repositories.MyContextDB context) => context.UnitOfMeasures.AddOrUpdate(x => x.Code,
                 new UnitOfMeasure() { Code = "UN", Description = "Unidad" },
                 new UnitOfMeasure() { Code = "KG", Description = "Kilogramo" },
                 new UnitOfMeasure() { Code = "LT", Description = "Litro" }
        );

        private void AddClients(JLA_Project.Repositories.MyContextDB context) => context.Clients.AddOrUpdate(x => x.Id,
            new Client() { Id = 1, FirstName = "Jane", LastName = "Austen" },
            new Client() { Id = 2, FirstName = "Charles", LastName = "Dickens" },
            new Client() { Id = 3, FirstName = "Miguel", LastName = "de Cervantes" }
        );

        private void AddProducts(JLA_Project.Repositories.MyContextDB context) => context.Products.AddOrUpdate(x => x.Id,
            new Product() { Id = 2, Code = "00002", Mark = "ACME", Model = "modelo 2", UnitOfMeasureId = "UN" },
            new Product() { Id = 3, Code = "00003", Mark = "ACME", Model = "modelo 3", UnitOfMeasureId = "UN" },
            new Product() { Id = 4, Code = "00004", Mark = "ACME", Model = "modelo 4", UnitOfMeasureId = "UN" },
            new Product() { Id = 5, Code = "00005", Mark = "ACME", Model = "modelo 5", UnitOfMeasureId = "UN" },
            new Product() { Id = 6, Code = "00006", Mark = "ACME", Model = "modelo 6", UnitOfMeasureId = "UN" },
            new Product() { Id = 7, Code = "00007", Mark = "ACME", Model = "modelo 7", UnitOfMeasureId = "UN" },
            new Product() { Id = 8, Code = "00008", Mark = "ACME", Model = "modelo 8", UnitOfMeasureId = "UN" },
            new Product() { Id = 9, Code = "00009", Mark = "ACME", Model = "modelo 9", UnitOfMeasureId = "UN" },
            new Product() { Id = 10, Code = "00010", Mark = "ACME", Model = "modelo 10", UnitOfMeasureId = "UN" },
            new Product() { Id = 11, Code = "00011", Mark = "ACME", Model = "modelo 11", UnitOfMeasureId = "UN" },
            new Product() { Id = 12, Code = "00012", Mark = "ACME", Model = "modelo 12", UnitOfMeasureId = "UN" },
            new Product() { Id = 13, Code = "00013", Mark = "ACME", Model = "modelo 13", UnitOfMeasureId = "UN" },
            new Product() { Id = 14, Code = "00014", Mark = "ACME", Model = "modelo 14", UnitOfMeasureId = "UN" },
            new Product() { Id = 15, Code = "00015", Mark = "ACME", Model = "modelo 15", UnitOfMeasureId = "UN" },
            new Product() { Id = 16, Code = "00016", Mark = "ACME", Model = "modelo 16", UnitOfMeasureId = "UN" },
            new Product() { Id = 17, Code = "00017", Mark = "ACME", Model = "modelo 17", UnitOfMeasureId = "UN" },
            new Product() { Id = 18, Code = "00018", Mark = "ACME", Model = "modelo 18", UnitOfMeasureId = "UN" },
            new Product() { Id = 19, Code = "00019", Mark = "ACME", Model = "modelo 19", UnitOfMeasureId = "UN" },
            new Product() { Id = 20, Code = "00020", Mark = "ACME", Model = "modelo 20", UnitOfMeasureId = "UN" },
            new Product() { Id = 21, Code = "00021", Mark = "ACME", Model = "modelo 21", UnitOfMeasureId = "UN" },
            new Product() { Id = 22, Code = "00022", Mark = "ACME", Model = "modelo 22", UnitOfMeasureId = "UN" },
            new Product() { Id = 23, Code = "00023", Mark = "ACME", Model = "modelo 23", UnitOfMeasureId = "UN" },
            new Product() { Id = 24, Code = "00024", Mark = "ACME", Model = "modelo 24", UnitOfMeasureId = "UN" },
            new Product() { Id = 25, Code = "00025", Mark = "ACME", Model = "modelo 25", UnitOfMeasureId = "UN" },
            new Product() { Id = 26, Code = "00026", Mark = "ACME", Model = "modelo 26", UnitOfMeasureId = "UN" },
            new Product() { Id = 27, Code = "00027", Mark = "ACME", Model = "modelo 27", UnitOfMeasureId = "UN" },
            new Product() { Id = 28, Code = "00028", Mark = "ACME", Model = "modelo 28", UnitOfMeasureId = "UN" },
            new Product() { Id = 29, Code = "00029", Mark = "ACME", Model = "modelo 29", UnitOfMeasureId = "UN" },
            new Product() { Id = 30, Code = "00030", Mark = "ACME", Model = "modelo 30", UnitOfMeasureId = "UN" },
            new Product() { Id = 31, Code = "00031", Mark = "ACME", Model = "modelo 31", UnitOfMeasureId = "UN" },
            new Product() { Id = 32, Code = "00032", Mark = "ACME", Model = "modelo 32", UnitOfMeasureId = "UN" },
            new Product() { Id = 33, Code = "00033", Mark = "ACME", Model = "modelo 33", UnitOfMeasureId = "UN" },
            new Product() { Id = 34, Code = "00034", Mark = "ACME", Model = "modelo 34", UnitOfMeasureId = "UN" },
            new Product() { Id = 35, Code = "00035", Mark = "ACME", Model = "modelo 35", UnitOfMeasureId = "UN" },
            new Product() { Id = 36, Code = "00036", Mark = "ACME", Model = "modelo 36", UnitOfMeasureId = "UN" },
            new Product() { Id = 37, Code = "00037", Mark = "ACME", Model = "modelo 37", UnitOfMeasureId = "UN" },
            new Product() { Id = 38, Code = "00038", Mark = "ACME", Model = "modelo 38", UnitOfMeasureId = "UN" },
            new Product() { Id = 39, Code = "00039", Mark = "ACME", Model = "modelo 39", UnitOfMeasureId = "UN" },
            new Product() { Id = 40, Code = "00040", Mark = "ACME", Model = "modelo 40", UnitOfMeasureId = "UN" },
            new Product() { Id = 41, Code = "00041", Mark = "ACME", Model = "modelo 41", UnitOfMeasureId = "UN" },
            new Product() { Id = 42, Code = "00042", Mark = "ACME", Model = "modelo 42", UnitOfMeasureId = "UN" },
            new Product() { Id = 43, Code = "00043", Mark = "ACME", Model = "modelo 43", UnitOfMeasureId = "UN" },
            new Product() { Id = 44, Code = "00044", Mark = "ACME", Model = "modelo 44", UnitOfMeasureId = "UN" },
            new Product() { Id = 45, Code = "00045", Mark = "ACME", Model = "modelo 45", UnitOfMeasureId = "UN" },
            new Product() { Id = 46, Code = "00046", Mark = "ACME", Model = "modelo 46", UnitOfMeasureId = "UN" },
            new Product() { Id = 47, Code = "00047", Mark = "ACME", Model = "modelo 47", UnitOfMeasureId = "UN" },
            new Product() { Id = 48, Code = "00048", Mark = "ACME", Model = "modelo 48", UnitOfMeasureId = "UN" },
            new Product() { Id = 49, Code = "00049", Mark = "ACME", Model = "modelo 49", UnitOfMeasureId = "UN" },
            new Product() { Id = 50, Code = "00050", Mark = "ACME", Model = "modelo 50", UnitOfMeasureId = "UN" },
            new Product() { Id = 51, Code = "00051", Mark = "ACME", Model = "modelo 51", UnitOfMeasureId = "UN" },
            new Product() { Id = 52, Code = "00052", Mark = "ACME", Model = "modelo 52", UnitOfMeasureId = "UN" },
            new Product() { Id = 53, Code = "00053", Mark = "ACME", Model = "modelo 53", UnitOfMeasureId = "UN" },
            new Product() { Id = 54, Code = "00054", Mark = "ACME", Model = "modelo 54", UnitOfMeasureId = "UN" },
            new Product() { Id = 55, Code = "00055", Mark = "ACME", Model = "modelo 55", UnitOfMeasureId = "UN" },
            new Product() { Id = 56, Code = "00056", Mark = "ACME", Model = "modelo 56", UnitOfMeasureId = "UN" },
            new Product() { Id = 57, Code = "00057", Mark = "ACME", Model = "modelo 57", UnitOfMeasureId = "UN" },
            new Product() { Id = 58, Code = "00058", Mark = "ACME", Model = "modelo 58", UnitOfMeasureId = "UN" },
            new Product() { Id = 59, Code = "00059", Mark = "ACME", Model = "modelo 59", UnitOfMeasureId = "UN" },
            new Product() { Id = 60, Code = "00060", Mark = "ACME", Model = "modelo 60", UnitOfMeasureId = "UN" },
            new Product() { Id = 61, Code = "00061", Mark = "ACME", Model = "modelo 61", UnitOfMeasureId = "UN" },
            new Product() { Id = 62, Code = "00062", Mark = "ACME", Model = "modelo 62", UnitOfMeasureId = "UN" },
            new Product() { Id = 63, Code = "00063", Mark = "ACME", Model = "modelo 63", UnitOfMeasureId = "UN" },
            new Product() { Id = 64, Code = "00064", Mark = "ACME", Model = "modelo 64", UnitOfMeasureId = "UN" },
            new Product() { Id = 65, Code = "00065", Mark = "ACME", Model = "modelo 65", UnitOfMeasureId = "UN" },
            new Product() { Id = 66, Code = "00066", Mark = "ACME", Model = "modelo 66", UnitOfMeasureId = "UN" },
            new Product() { Id = 67, Code = "00067", Mark = "ACME", Model = "modelo 67", UnitOfMeasureId = "UN" },
            new Product() { Id = 68, Code = "00068", Mark = "ACME", Model = "modelo 68", UnitOfMeasureId = "UN" },
            new Product() { Id = 69, Code = "00069", Mark = "ACME", Model = "modelo 69", UnitOfMeasureId = "UN" },
            new Product() { Id = 70, Code = "00070", Mark = "ACME", Model = "modelo 70", UnitOfMeasureId = "UN" },
            new Product() { Id = 71, Code = "00071", Mark = "ACME", Model = "modelo 71", UnitOfMeasureId = "UN" },
            new Product() { Id = 72, Code = "00072", Mark = "ACME", Model = "modelo 72", UnitOfMeasureId = "UN" },
            new Product() { Id = 73, Code = "00073", Mark = "ACME", Model = "modelo 73", UnitOfMeasureId = "UN" },
            new Product() { Id = 74, Code = "00074", Mark = "ACME", Model = "modelo 74", UnitOfMeasureId = "UN" },
            new Product() { Id = 75, Code = "00075", Mark = "ACME", Model = "modelo 75", UnitOfMeasureId = "UN" },
            new Product() { Id = 76, Code = "00076", Mark = "ACME", Model = "modelo 76", UnitOfMeasureId = "UN" },
            new Product() { Id = 77, Code = "00077", Mark = "ACME", Model = "modelo 77", UnitOfMeasureId = "UN" },
            new Product() { Id = 78, Code = "00078", Mark = "ACME", Model = "modelo 78", UnitOfMeasureId = "UN" },
            new Product() { Id = 79, Code = "00079", Mark = "ACME", Model = "modelo 79", UnitOfMeasureId = "UN" },
            new Product() { Id = 80, Code = "00080", Mark = "ACME", Model = "modelo 80", UnitOfMeasureId = "UN" },
            new Product() { Id = 81, Code = "00081", Mark = "ACME", Model = "modelo 81", UnitOfMeasureId = "UN" },
            new Product() { Id = 82, Code = "00082", Mark = "ACME", Model = "modelo 82", UnitOfMeasureId = "UN" },
            new Product() { Id = 83, Code = "00083", Mark = "ACME", Model = "modelo 83", UnitOfMeasureId = "UN" },
            new Product() { Id = 84, Code = "00084", Mark = "ACME", Model = "modelo 84", UnitOfMeasureId = "UN" },
            new Product() { Id = 85, Code = "00085", Mark = "ACME", Model = "modelo 85", UnitOfMeasureId = "UN" },
            new Product() { Id = 86, Code = "00086", Mark = "ACME", Model = "modelo 86", UnitOfMeasureId = "UN" },
            new Product() { Id = 87, Code = "00087", Mark = "ACME", Model = "modelo 87", UnitOfMeasureId = "UN" },
            new Product() { Id = 88, Code = "00088", Mark = "ACME", Model = "modelo 88", UnitOfMeasureId = "UN" },
            new Product() { Id = 89, Code = "00089", Mark = "ACME", Model = "modelo 89", UnitOfMeasureId = "UN" },
            new Product() { Id = 90, Code = "00090", Mark = "ACME", Model = "modelo 90", UnitOfMeasureId = "UN" },
            new Product() { Id = 91, Code = "00091", Mark = "ACME", Model = "modelo 91", UnitOfMeasureId = "UN" },
            new Product() { Id = 92, Code = "00092", Mark = "ACME", Model = "modelo 92", UnitOfMeasureId = "UN" },
            new Product() { Id = 93, Code = "00093", Mark = "ACME", Model = "modelo 93", UnitOfMeasureId = "UN" },
            new Product() { Id = 94, Code = "00094", Mark = "ACME", Model = "modelo 94", UnitOfMeasureId = "UN" },
            new Product() { Id = 95, Code = "00095", Mark = "ACME", Model = "modelo 95", UnitOfMeasureId = "UN" },
            new Product() { Id = 96, Code = "00096", Mark = "ACME", Model = "modelo 96", UnitOfMeasureId = "UN" },
            new Product() { Id = 97, Code = "00097", Mark = "ACME", Model = "modelo 97", UnitOfMeasureId = "UN" },
            new Product() { Id = 98, Code = "00098", Mark = "ACME", Model = "modelo 98", UnitOfMeasureId = "UN" },
            new Product() { Id = 99, Code = "00099", Mark = "ACME", Model = "modelo 99", UnitOfMeasureId = "UN" },
            new Product() { Id = 100, Code = "00100", Mark = "ACME", Model = "modelo 100", UnitOfMeasureId = "UN" },
            new Product() { Id = 101, Code = "00101", Mark = "ACME", Model = "modelo 101", UnitOfMeasureId = "UN" },
            new Product() { Id = 102, Code = "00102", Mark = "ACME", Model = "modelo 102", UnitOfMeasureId = "UN" },
            new Product() { Id = 103, Code = "00103", Mark = "ACME", Model = "modelo 103", UnitOfMeasureId = "UN" },
            new Product() { Id = 104, Code = "00104", Mark = "ACME", Model = "modelo 104", UnitOfMeasureId = "UN" },
            new Product() { Id = 105, Code = "00105", Mark = "ACME", Model = "modelo 105", UnitOfMeasureId = "UN" },
            new Product() { Id = 106, Code = "00106", Mark = "ACME", Model = "modelo 106", UnitOfMeasureId = "UN" },
            new Product() { Id = 107, Code = "00107", Mark = "ACME", Model = "modelo 107", UnitOfMeasureId = "UN" },
            new Product() { Id = 108, Code = "00108", Mark = "ACME", Model = "modelo 108", UnitOfMeasureId = "UN" },
            new Product() { Id = 109, Code = "00109", Mark = "ACME", Model = "modelo 109", UnitOfMeasureId = "UN" },
            new Product() { Id = 110, Code = "00110", Mark = "ACME", Model = "modelo 110", UnitOfMeasureId = "UN" },
            new Product() { Id = 111, Code = "00111", Mark = "ACME", Model = "modelo 111", UnitOfMeasureId = "UN" },
            new Product() { Id = 112, Code = "00112", Mark = "ACME", Model = "modelo 112", UnitOfMeasureId = "UN" },
            new Product() { Id = 113, Code = "00113", Mark = "ACME", Model = "modelo 113", UnitOfMeasureId = "UN" },
            new Product() { Id = 114, Code = "00114", Mark = "ACME", Model = "modelo 114", UnitOfMeasureId = "UN" },
            new Product() { Id = 115, Code = "00115", Mark = "ACME", Model = "modelo 115", UnitOfMeasureId = "UN" },
            new Product() { Id = 116, Code = "00116", Mark = "ACME", Model = "modelo 116", UnitOfMeasureId = "UN" },
            new Product() { Id = 117, Code = "00117", Mark = "ACME", Model = "modelo 117", UnitOfMeasureId = "UN" },
            new Product() { Id = 118, Code = "00118", Mark = "ACME", Model = "modelo 118", UnitOfMeasureId = "UN" },
            new Product() { Id = 119, Code = "00119", Mark = "ACME", Model = "modelo 119", UnitOfMeasureId = "UN" },
            new Product() { Id = 120, Code = "00120", Mark = "ACME", Model = "modelo 120", UnitOfMeasureId = "UN" },
            new Product() { Id = 121, Code = "00121", Mark = "ACME", Model = "modelo 121", UnitOfMeasureId = "UN" },
            new Product() { Id = 122, Code = "00122", Mark = "ACME", Model = "modelo 122", UnitOfMeasureId = "UN" },
            new Product() { Id = 123, Code = "00123", Mark = "ACME", Model = "modelo 123", UnitOfMeasureId = "UN" },
            new Product() { Id = 124, Code = "00124", Mark = "ACME", Model = "modelo 124", UnitOfMeasureId = "UN" },
            new Product() { Id = 125, Code = "00125", Mark = "ACME", Model = "modelo 125", UnitOfMeasureId = "UN" },
            new Product() { Id = 126, Code = "00126", Mark = "ACME", Model = "modelo 126", UnitOfMeasureId = "UN" },
            new Product() { Id = 127, Code = "00127", Mark = "ACME", Model = "modelo 127", UnitOfMeasureId = "UN" },
            new Product() { Id = 128, Code = "00128", Mark = "ACME", Model = "modelo 128", UnitOfMeasureId = "UN" },
            new Product() { Id = 129, Code = "00129", Mark = "ACME", Model = "modelo 129", UnitOfMeasureId = "UN" },
            new Product() { Id = 130, Code = "00130", Mark = "ACME", Model = "modelo 130", UnitOfMeasureId = "UN" },
            new Product() { Id = 131, Code = "00131", Mark = "ACME", Model = "modelo 131", UnitOfMeasureId = "UN" },
            new Product() { Id = 132, Code = "00132", Mark = "ACME", Model = "modelo 132", UnitOfMeasureId = "UN" },
            new Product() { Id = 133, Code = "00133", Mark = "ACME", Model = "modelo 133", UnitOfMeasureId = "UN" },
            new Product() { Id = 134, Code = "00134", Mark = "ACME", Model = "modelo 134", UnitOfMeasureId = "UN" },
            new Product() { Id = 135, Code = "00135", Mark = "ACME", Model = "modelo 135", UnitOfMeasureId = "UN" },
            new Product() { Id = 136, Code = "00136", Mark = "ACME", Model = "modelo 136", UnitOfMeasureId = "UN" },
            new Product() { Id = 137, Code = "00137", Mark = "ACME", Model = "modelo 137", UnitOfMeasureId = "UN" },
            new Product() { Id = 138, Code = "00138", Mark = "ACME", Model = "modelo 138", UnitOfMeasureId = "UN" },
            new Product() { Id = 139, Code = "00139", Mark = "ACME", Model = "modelo 139", UnitOfMeasureId = "UN" },
            new Product() { Id = 140, Code = "00140", Mark = "ACME", Model = "modelo 140", UnitOfMeasureId = "UN" },
            new Product() { Id = 141, Code = "00141", Mark = "ACME", Model = "modelo 141", UnitOfMeasureId = "UN" },
            new Product() { Id = 142, Code = "00142", Mark = "ACME", Model = "modelo 142", UnitOfMeasureId = "UN" },
            new Product() { Id = 143, Code = "00143", Mark = "ACME", Model = "modelo 143", UnitOfMeasureId = "UN" },
            new Product() { Id = 144, Code = "00144", Mark = "ACME", Model = "modelo 144", UnitOfMeasureId = "UN" },
            new Product() { Id = 145, Code = "00145", Mark = "ACME", Model = "modelo 145", UnitOfMeasureId = "UN" },
            new Product() { Id = 146, Code = "00146", Mark = "ACME", Model = "modelo 146", UnitOfMeasureId = "UN" },
            new Product() { Id = 147, Code = "00147", Mark = "ACME", Model = "modelo 147", UnitOfMeasureId = "UN" },
            new Product() { Id = 148, Code = "00148", Mark = "ACME", Model = "modelo 148", UnitOfMeasureId = "UN" },
            new Product() { Id = 149, Code = "00149", Mark = "ACME", Model = "modelo 149", UnitOfMeasureId = "UN" },
            new Product() { Id = 150, Code = "00150", Mark = "ACME", Model = "modelo 150", UnitOfMeasureId = "UN" },
            new Product() { Id = 151, Code = "00151", Mark = "ACME", Model = "modelo 151", UnitOfMeasureId = "UN" },
            new Product() { Id = 152, Code = "00152", Mark = "ACME", Model = "modelo 152", UnitOfMeasureId = "UN" },
            new Product() { Id = 153, Code = "00153", Mark = "ACME", Model = "modelo 153", UnitOfMeasureId = "UN" },
            new Product() { Id = 154, Code = "00154", Mark = "ACME", Model = "modelo 154", UnitOfMeasureId = "UN" },
            new Product() { Id = 155, Code = "00155", Mark = "ACME", Model = "modelo 155", UnitOfMeasureId = "UN" },
            new Product() { Id = 156, Code = "00156", Mark = "ACME", Model = "modelo 156", UnitOfMeasureId = "UN" },
            new Product() { Id = 157, Code = "00157", Mark = "ACME", Model = "modelo 157", UnitOfMeasureId = "UN" },
            new Product() { Id = 158, Code = "00158", Mark = "ACME", Model = "modelo 158", UnitOfMeasureId = "UN" },
            new Product() { Id = 159, Code = "00159", Mark = "ACME", Model = "modelo 159", UnitOfMeasureId = "UN" },
            new Product() { Id = 160, Code = "00160", Mark = "ACME", Model = "modelo 160", UnitOfMeasureId = "UN" },
            new Product() { Id = 161, Code = "00161", Mark = "ACME", Model = "modelo 161", UnitOfMeasureId = "UN" },
            new Product() { Id = 162, Code = "00162", Mark = "ACME", Model = "modelo 162", UnitOfMeasureId = "UN" },
            new Product() { Id = 163, Code = "00163", Mark = "ACME", Model = "modelo 163", UnitOfMeasureId = "UN" },
            new Product() { Id = 164, Code = "00164", Mark = "ACME", Model = "modelo 164", UnitOfMeasureId = "UN" },
            new Product() { Id = 165, Code = "00165", Mark = "ACME", Model = "modelo 165", UnitOfMeasureId = "UN" },
            new Product() { Id = 166, Code = "00166", Mark = "ACME", Model = "modelo 166", UnitOfMeasureId = "UN" },
            new Product() { Id = 167, Code = "00167", Mark = "ACME", Model = "modelo 167", UnitOfMeasureId = "UN" },
            new Product() { Id = 168, Code = "00168", Mark = "ACME", Model = "modelo 168", UnitOfMeasureId = "UN" },
            new Product() { Id = 169, Code = "00169", Mark = "ACME", Model = "modelo 169", UnitOfMeasureId = "UN" },
            new Product() { Id = 170, Code = "00170", Mark = "ACME", Model = "modelo 170", UnitOfMeasureId = "UN" },
            new Product() { Id = 171, Code = "00171", Mark = "ACME", Model = "modelo 171", UnitOfMeasureId = "UN" },
            new Product() { Id = 172, Code = "00172", Mark = "ACME", Model = "modelo 172", UnitOfMeasureId = "UN" },
            new Product() { Id = 173, Code = "00173", Mark = "ACME", Model = "modelo 173", UnitOfMeasureId = "UN" },
            new Product() { Id = 174, Code = "00174", Mark = "ACME", Model = "modelo 174", UnitOfMeasureId = "UN" },
            new Product() { Id = 175, Code = "00175", Mark = "ACME", Model = "modelo 175", UnitOfMeasureId = "UN" },
            new Product() { Id = 176, Code = "00176", Mark = "ACME", Model = "modelo 176", UnitOfMeasureId = "UN" },
            new Product() { Id = 177, Code = "00177", Mark = "ACME", Model = "modelo 177", UnitOfMeasureId = "UN" },
            new Product() { Id = 178, Code = "00178", Mark = "ACME", Model = "modelo 178", UnitOfMeasureId = "UN" },
            new Product() { Id = 179, Code = "00179", Mark = "ACME", Model = "modelo 179", UnitOfMeasureId = "UN" },
            new Product() { Id = 180, Code = "00180", Mark = "ACME", Model = "modelo 180", UnitOfMeasureId = "UN" },
            new Product() { Id = 181, Code = "00181", Mark = "ACME", Model = "modelo 181", UnitOfMeasureId = "UN" },
            new Product() { Id = 182, Code = "00182", Mark = "ACME", Model = "modelo 182", UnitOfMeasureId = "UN" },
            new Product() { Id = 183, Code = "00183", Mark = "ACME", Model = "modelo 183", UnitOfMeasureId = "UN" },
            new Product() { Id = 184, Code = "00184", Mark = "ACME", Model = "modelo 184", UnitOfMeasureId = "UN" },
            new Product() { Id = 185, Code = "00185", Mark = "ACME", Model = "modelo 185", UnitOfMeasureId = "UN" },
            new Product() { Id = 186, Code = "00186", Mark = "ACME", Model = "modelo 186", UnitOfMeasureId = "UN" },
            new Product() { Id = 187, Code = "00187", Mark = "ACME", Model = "modelo 187", UnitOfMeasureId = "UN" },
            new Product() { Id = 188, Code = "00188", Mark = "ACME", Model = "modelo 188", UnitOfMeasureId = "UN" },
            new Product() { Id = 189, Code = "00189", Mark = "ACME", Model = "modelo 189", UnitOfMeasureId = "UN" },
            new Product() { Id = 190, Code = "00190", Mark = "ACME", Model = "modelo 190", UnitOfMeasureId = "UN" },
            new Product() { Id = 191, Code = "00191", Mark = "ACME", Model = "modelo 191", UnitOfMeasureId = "UN" },
            new Product() { Id = 192, Code = "00192", Mark = "ACME", Model = "modelo 192", UnitOfMeasureId = "UN" },
            new Product() { Id = 193, Code = "00193", Mark = "ACME", Model = "modelo 193", UnitOfMeasureId = "UN" },
            new Product() { Id = 194, Code = "00194", Mark = "ACME", Model = "modelo 194", UnitOfMeasureId = "UN" },
            new Product() { Id = 195, Code = "00195", Mark = "ACME", Model = "modelo 195", UnitOfMeasureId = "UN" },
            new Product() { Id = 196, Code = "00196", Mark = "ACME", Model = "modelo 196", UnitOfMeasureId = "UN" },
            new Product() { Id = 197, Code = "00197", Mark = "ACME", Model = "modelo 197", UnitOfMeasureId = "UN" },
            new Product() { Id = 198, Code = "00198", Mark = "ACME", Model = "modelo 198", UnitOfMeasureId = "UN" },
            new Product() { Id = 199, Code = "00199", Mark = "ACME", Model = "modelo 199", UnitOfMeasureId = "UN" },
            new Product() { Id = 200, Code = "00200", Mark = "ACME", Model = "modelo 200", UnitOfMeasureId = "UN" },
            new Product() { Id = 201, Code = "00201", Mark = "ACME", Model = "modelo 201", UnitOfMeasureId = "UN" },
            new Product() { Id = 202, Code = "00202", Mark = "ACME", Model = "modelo 202", UnitOfMeasureId = "UN" },
            new Product() { Id = 203, Code = "00203", Mark = "ACME", Model = "modelo 203", UnitOfMeasureId = "UN" },
            new Product() { Id = 204, Code = "00204", Mark = "ACME", Model = "modelo 204", UnitOfMeasureId = "UN" },
            new Product() { Id = 205, Code = "00205", Mark = "ACME", Model = "modelo 205", UnitOfMeasureId = "UN" },
            new Product() { Id = 206, Code = "00206", Mark = "ACME", Model = "modelo 206", UnitOfMeasureId = "UN" },
            new Product() { Id = 207, Code = "00207", Mark = "ACME", Model = "modelo 207", UnitOfMeasureId = "UN" },
            new Product() { Id = 208, Code = "00208", Mark = "ACME", Model = "modelo 208", UnitOfMeasureId = "UN" },
            new Product() { Id = 209, Code = "00209", Mark = "ACME", Model = "modelo 209", UnitOfMeasureId = "UN" },
            new Product() { Id = 210, Code = "00210", Mark = "ACME", Model = "modelo 210", UnitOfMeasureId = "UN" },
            new Product() { Id = 211, Code = "00211", Mark = "ACME", Model = "modelo 211", UnitOfMeasureId = "UN" },
            new Product() { Id = 212, Code = "00212", Mark = "ACME", Model = "modelo 212", UnitOfMeasureId = "UN" },
            new Product() { Id = 213, Code = "00213", Mark = "ACME", Model = "modelo 213", UnitOfMeasureId = "UN" },
            new Product() { Id = 214, Code = "00214", Mark = "ACME", Model = "modelo 214", UnitOfMeasureId = "UN" },
            new Product() { Id = 215, Code = "00215", Mark = "ACME", Model = "modelo 215", UnitOfMeasureId = "UN" },
            new Product() { Id = 216, Code = "00216", Mark = "ACME", Model = "modelo 216", UnitOfMeasureId = "UN" },
            new Product() { Id = 217, Code = "00217", Mark = "ACME", Model = "modelo 217", UnitOfMeasureId = "UN" },
            new Product() { Id = 218, Code = "00218", Mark = "ACME", Model = "modelo 218", UnitOfMeasureId = "UN" },
            new Product() { Id = 219, Code = "00219", Mark = "ACME", Model = "modelo 219", UnitOfMeasureId = "UN" },
            new Product() { Id = 220, Code = "00220", Mark = "ACME", Model = "modelo 220", UnitOfMeasureId = "UN" },
            new Product() { Id = 221, Code = "00221", Mark = "ACME", Model = "modelo 221", UnitOfMeasureId = "UN" },
            new Product() { Id = 222, Code = "00222", Mark = "ACME", Model = "modelo 222", UnitOfMeasureId = "UN" },
            new Product() { Id = 223, Code = "00223", Mark = "ACME", Model = "modelo 223", UnitOfMeasureId = "UN" },
            new Product() { Id = 224, Code = "00224", Mark = "ACME", Model = "modelo 224", UnitOfMeasureId = "UN" },
            new Product() { Id = 225, Code = "00225", Mark = "ACME", Model = "modelo 225", UnitOfMeasureId = "UN" },
            new Product() { Id = 226, Code = "00226", Mark = "ACME", Model = "modelo 226", UnitOfMeasureId = "UN" },
            new Product() { Id = 227, Code = "00227", Mark = "ACME", Model = "modelo 227", UnitOfMeasureId = "UN" },
            new Product() { Id = 228, Code = "00228", Mark = "ACME", Model = "modelo 228", UnitOfMeasureId = "UN" },
            new Product() { Id = 229, Code = "00229", Mark = "ACME", Model = "modelo 229", UnitOfMeasureId = "UN" },
            new Product() { Id = 230, Code = "00230", Mark = "ACME", Model = "modelo 230", UnitOfMeasureId = "UN" },
            new Product() { Id = 231, Code = "00231", Mark = "ACME", Model = "modelo 231", UnitOfMeasureId = "UN" },
            new Product() { Id = 232, Code = "00232", Mark = "ACME", Model = "modelo 232", UnitOfMeasureId = "UN" },
            new Product() { Id = 233, Code = "00233", Mark = "ACME", Model = "modelo 233", UnitOfMeasureId = "UN" },
            new Product() { Id = 234, Code = "00234", Mark = "ACME", Model = "modelo 234", UnitOfMeasureId = "UN" },
            new Product() { Id = 235, Code = "00235", Mark = "ACME", Model = "modelo 235", UnitOfMeasureId = "UN" },
            new Product() { Id = 236, Code = "00236", Mark = "ACME", Model = "modelo 236", UnitOfMeasureId = "UN" },
            new Product() { Id = 237, Code = "00237", Mark = "ACME", Model = "modelo 237", UnitOfMeasureId = "UN" },
            new Product() { Id = 238, Code = "00238", Mark = "ACME", Model = "modelo 238", UnitOfMeasureId = "UN" },
            new Product() { Id = 239, Code = "00239", Mark = "ACME", Model = "modelo 239", UnitOfMeasureId = "UN" },
            new Product() { Id = 240, Code = "00240", Mark = "ACME", Model = "modelo 240", UnitOfMeasureId = "UN" },
            new Product() { Id = 241, Code = "00241", Mark = "ACME", Model = "modelo 241", UnitOfMeasureId = "UN" },
            new Product() { Id = 242, Code = "00242", Mark = "ACME", Model = "modelo 242", UnitOfMeasureId = "UN" },
            new Product() { Id = 243, Code = "00243", Mark = "ACME", Model = "modelo 243", UnitOfMeasureId = "UN" },
            new Product() { Id = 244, Code = "00244", Mark = "ACME", Model = "modelo 244", UnitOfMeasureId = "UN" },
            new Product() { Id = 245, Code = "00245", Mark = "ACME", Model = "modelo 245", UnitOfMeasureId = "UN" },
            new Product() { Id = 246, Code = "00246", Mark = "ACME", Model = "modelo 246", UnitOfMeasureId = "UN" },
            new Product() { Id = 247, Code = "00247", Mark = "ACME", Model = "modelo 247", UnitOfMeasureId = "UN" },
            new Product() { Id = 248, Code = "00248", Mark = "ACME", Model = "modelo 248", UnitOfMeasureId = "UN" },
            new Product() { Id = 249, Code = "00249", Mark = "ACME", Model = "modelo 249", UnitOfMeasureId = "UN" },
            new Product() { Id = 250, Code = "00250", Mark = "ACME", Model = "modelo 250", UnitOfMeasureId = "UN" },
            new Product() { Id = 251, Code = "00251", Mark = "ACME", Model = "modelo 251", UnitOfMeasureId = "UN" },
            new Product() { Id = 252, Code = "00252", Mark = "ACME", Model = "modelo 252", UnitOfMeasureId = "UN" },
            new Product() { Id = 253, Code = "00253", Mark = "ACME", Model = "modelo 253", UnitOfMeasureId = "UN" },
            new Product() { Id = 254, Code = "00254", Mark = "ACME", Model = "modelo 254", UnitOfMeasureId = "UN" },
            new Product() { Id = 255, Code = "00255", Mark = "ACME", Model = "modelo 255", UnitOfMeasureId = "UN" },
            new Product() { Id = 256, Code = "00256", Mark = "ACME", Model = "modelo 256", UnitOfMeasureId = "UN" },
            new Product() { Id = 257, Code = "00257", Mark = "ACME", Model = "modelo 257", UnitOfMeasureId = "UN" },
            new Product() { Id = 258, Code = "00258", Mark = "ACME", Model = "modelo 258", UnitOfMeasureId = "UN" },
            new Product() { Id = 259, Code = "00259", Mark = "ACME", Model = "modelo 259", UnitOfMeasureId = "UN" },
            new Product() { Id = 260, Code = "00260", Mark = "ACME", Model = "modelo 260", UnitOfMeasureId = "UN" },
            new Product() { Id = 261, Code = "00261", Mark = "ACME", Model = "modelo 261", UnitOfMeasureId = "UN" },
            new Product() { Id = 262, Code = "00262", Mark = "ACME", Model = "modelo 262", UnitOfMeasureId = "UN" },
            new Product() { Id = 263, Code = "00263", Mark = "ACME", Model = "modelo 263", UnitOfMeasureId = "UN" },
            new Product() { Id = 264, Code = "00264", Mark = "ACME", Model = "modelo 264", UnitOfMeasureId = "UN" },
            new Product() { Id = 265, Code = "00265", Mark = "ACME", Model = "modelo 265", UnitOfMeasureId = "UN" },
            new Product() { Id = 266, Code = "00266", Mark = "ACME", Model = "modelo 266", UnitOfMeasureId = "UN" },
            new Product() { Id = 267, Code = "00267", Mark = "ACME", Model = "modelo 267", UnitOfMeasureId = "UN" },
            new Product() { Id = 268, Code = "00268", Mark = "ACME", Model = "modelo 268", UnitOfMeasureId = "UN" },
            new Product() { Id = 269, Code = "00269", Mark = "ACME", Model = "modelo 269", UnitOfMeasureId = "UN" },
            new Product() { Id = 270, Code = "00270", Mark = "ACME", Model = "modelo 270", UnitOfMeasureId = "UN" },
            new Product() { Id = 271, Code = "00271", Mark = "ACME", Model = "modelo 271", UnitOfMeasureId = "UN" },
            new Product() { Id = 272, Code = "00272", Mark = "ACME", Model = "modelo 272", UnitOfMeasureId = "UN" },
            new Product() { Id = 273, Code = "00273", Mark = "ACME", Model = "modelo 273", UnitOfMeasureId = "UN" },
            new Product() { Id = 274, Code = "00274", Mark = "ACME", Model = "modelo 274", UnitOfMeasureId = "UN" },
            new Product() { Id = 275, Code = "00275", Mark = "ACME", Model = "modelo 275", UnitOfMeasureId = "UN" },
            new Product() { Id = 276, Code = "00276", Mark = "ACME", Model = "modelo 276", UnitOfMeasureId = "UN" },
            new Product() { Id = 277, Code = "00277", Mark = "ACME", Model = "modelo 277", UnitOfMeasureId = "UN" },
            new Product() { Id = 278, Code = "00278", Mark = "ACME", Model = "modelo 278", UnitOfMeasureId = "UN" },
            new Product() { Id = 279, Code = "00279", Mark = "ACME", Model = "modelo 279", UnitOfMeasureId = "UN" },
            new Product() { Id = 280, Code = "00280", Mark = "ACME", Model = "modelo 280", UnitOfMeasureId = "UN" },
            new Product() { Id = 281, Code = "00281", Mark = "ACME", Model = "modelo 281", UnitOfMeasureId = "UN" },
            new Product() { Id = 282, Code = "00282", Mark = "ACME", Model = "modelo 282", UnitOfMeasureId = "UN" },
            new Product() { Id = 283, Code = "00283", Mark = "ACME", Model = "modelo 283", UnitOfMeasureId = "UN" },
            new Product() { Id = 284, Code = "00284", Mark = "ACME", Model = "modelo 284", UnitOfMeasureId = "UN" },
            new Product() { Id = 285, Code = "00285", Mark = "ACME", Model = "modelo 285", UnitOfMeasureId = "UN" },
            new Product() { Id = 286, Code = "00286", Mark = "ACME", Model = "modelo 286", UnitOfMeasureId = "UN" },
            new Product() { Id = 287, Code = "00287", Mark = "ACME", Model = "modelo 287", UnitOfMeasureId = "UN" },
            new Product() { Id = 288, Code = "00288", Mark = "ACME", Model = "modelo 288", UnitOfMeasureId = "UN" },
            new Product() { Id = 289, Code = "00289", Mark = "ACME", Model = "modelo 289", UnitOfMeasureId = "UN" },
            new Product() { Id = 290, Code = "00290", Mark = "ACME", Model = "modelo 290", UnitOfMeasureId = "UN" },
            new Product() { Id = 291, Code = "00291", Mark = "ACME", Model = "modelo 291", UnitOfMeasureId = "UN" },
            new Product() { Id = 292, Code = "00292", Mark = "ACME", Model = "modelo 292", UnitOfMeasureId = "UN" },
            new Product() { Id = 293, Code = "00293", Mark = "ACME", Model = "modelo 293", UnitOfMeasureId = "UN" },
            new Product() { Id = 294, Code = "00294", Mark = "ACME", Model = "modelo 294", UnitOfMeasureId = "UN" },
            new Product() { Id = 295, Code = "00295", Mark = "ACME", Model = "modelo 295", UnitOfMeasureId = "UN" },
            new Product() { Id = 296, Code = "00296", Mark = "ACME", Model = "modelo 296", UnitOfMeasureId = "UN" },
            new Product() { Id = 297, Code = "00297", Mark = "ACME", Model = "modelo 297", UnitOfMeasureId = "UN" },
            new Product() { Id = 298, Code = "00298", Mark = "ACME", Model = "modelo 298", UnitOfMeasureId = "UN" },
            new Product() { Id = 299, Code = "00299", Mark = "ACME", Model = "modelo 299", UnitOfMeasureId = "UN" },
            new Product() { Id = 300, Code = "00300", Mark = "ACME", Model = "modelo 300", UnitOfMeasureId = "UN" },
            new Product() { Id = 301, Code = "00301", Mark = "ACME", Model = "modelo 301", UnitOfMeasureId = "UN" }

        );



    }
}
