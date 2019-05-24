using FluentMigrator;

namespace FluentMigratorSales.Migrations
{
    [Migration(2)]
    public class CreateProductsTable : Migration
    {
        public override void Up()
        {
            Create.Table("Products")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(255).NotNullable()
                .WithColumn("Price").AsDecimal().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Products");
        }
    }
}
