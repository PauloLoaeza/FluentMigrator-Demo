using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;

namespace FluentMigratorSales.Migrations
{
    [Profile("Development")]
    [Migration(6)]
    public class SeedDatabase : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Customers")
                .Row(new {FirstName = "Luis", LastName = "Loaeza"})
                .Row(new {FirstName = "Emilio", LastName = "Galván"})
                .Row(new {FirstName = "Francisco", LastName = "Rivera"})
                .Row(new {FirstName = "Fabián", LastName = "Oñete"});

            Insert.IntoTable("Products")
                .Row(new {Name = "Coca Cola 600ml", Price = 12.0})
                .Row(new {Name = "Donas 25g", Price = 11.50})
                .Row(new {Name = "Sabritas 20g", Price = 12.0})
                .Row(new {Name = "Jugo 355ml", Price = 8.50})
                .Row(new {Name = "Takis 22g", Price = 11.0})
                .Row(new {Name = "Zucaritas 125g", Price = 45.0})
                .Row(new {Name = "Danup 425ml", Price = 10.50});

            Insert.IntoTable("Sales")
                .Row(new {CustomerId = 1, ProductId = 1, Quantity = 1, Total = 12.0})
                .Row(new {CustomerId = 2, ProductId = 3, Quantity = 3, Total = 36.0})
                .Row(new {CustomerId = 3, ProductId = 5, Quantity = 2, Total = 22.0})
                .Row(new {CustomerId = 4, ProductId = 7, Quantity = 5, Total = 52.50})
                .Row(new {CustomerId = 1, ProductId = 2, Quantity = 4, Total = 46.0});
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
