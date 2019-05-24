using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;

namespace FluentMigratorSales.Migrations
{
    [Migration(5)]
    public class RenameTotalPriceToTotalInSalesTable : Migration
    {
        public override void Up()
        {
            Rename.Column("TotalPrice")
                .OnTable("Sales")
                .To("Total");
        }

        public override void Down()
        {
            Rename.Column("Total")
                .OnTable("Sales")
                .To("TotalPrice");
        }
    }
}
