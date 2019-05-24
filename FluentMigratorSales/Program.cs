using System;
using FluentMigrator.Runner;
using FluentMigratorSales.Migrations;
using Microsoft.Extensions.DependencyInjection;

namespace FluentMigratorSales
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = CreateServices(); 

            using (var scope = serviceProvider.CreateScope())
                UpdateDatabase(scope.ServiceProvider);
        }

        private static IServiceProvider CreateServices()
        {
            var connectionString = "Server=localhost\\SQLEXPRESS; Database=fluent-migrator-sales; Integrated Security=True";

            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(typeof(CreateCustomersTable).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            runner.MigrateUp();
        }
    }
}
