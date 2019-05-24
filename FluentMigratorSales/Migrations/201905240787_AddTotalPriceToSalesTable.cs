using FluentMigrator;

namespace FluentMigratorSales.Migrations
{
    [Migration(4)]
    public class AddTotalPriceToSalesTable : Migration
    {
        public override void Up()
        {
            Alter.Table("Sales")
                .AddColumn("TotalPrice").AsDecimal().NotNullable().WithDefaultValue(0.0);
        }

        public override void Down()
        {
            Delete.Column("TotalPrice").FromTable("Sales");
        }
    }
}
