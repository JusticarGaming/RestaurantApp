using Resturaunt_Manager.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;


namespace Resturaunt_Manager.DBContext
{
    public class RestaurantDatabase : DbContext
    {
        public IDbSet<Account> Account { get; set; }
        public IDbSet<Waiter> Waiter { get; set; }
        public IDbSet<Table> Table { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<MenuItem> MenuItems { get; set; }

        public RestaurantDatabase() : base("RestaurantDB") { }

        #region Auto Migration

        class DatabaseConfig : DbMigrationsConfiguration<RestaurantDatabase>
        {
            public DatabaseConfig()
            {
                AutomaticMigrationsEnabled = true;
                AutomaticMigrationDataLossAllowed = true;
            }
        }

        static RestaurantDatabase() 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantDatabase, DatabaseConfig>());
        }

        #endregion
    }
}