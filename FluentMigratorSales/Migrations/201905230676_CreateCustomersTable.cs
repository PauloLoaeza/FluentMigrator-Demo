using FluentMigrator;

namespace FluentMigratorSales.Migrations
{
    [Migration(1)]
    public class CreateCustomersTable : Migration

    {
        public override void Up()
        {
            Create.Table("Customers")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("FirstName").AsString(255).NotNullable()
                .WithColumn("LastName").AsString(255).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Customers");
        }
    }
}
