using System.Data;
using FluentMigrator;

namespace FluentMigratorSales.Migrations
{
    [Migration(3)]
    public class CreateSalesTable : Migration
    {
        public override void Up()
        {
            Create.Table("Sales")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Quantity").AsInt32().NotNullable()
                .WithColumn("CustomerId").AsInt32().NotNullable()
                .WithColumn("ProductId").AsInt32().NotNullable();

            Create.ForeignKey()
                .FromTable("Sales").ForeignColumn("CustomerId")
                .ToTable("Customers").PrimaryColumn("Id")
                .OnDelete(Rule.None);

            Create.ForeignKey()
                .FromTable("Sales").ForeignColumn("ProductId")
                .ToTable("Products").PrimaryColumn("Id")
                .OnDelete(Rule.None);
        }

        public override void Down()
        {
            Delete.ForeignKey()
                .FromTable("Sales").ForeignColumn("ProductId")
                .ToTable("Products").PrimaryColumn("Id");

            Delete.ForeignKey()
                .FromTable("Sales").ForeignColumn("CustomerId")
                .ToTable("Customers").PrimaryColumn("Id");

            Delete.Table("Sales");
        }
    }
}
