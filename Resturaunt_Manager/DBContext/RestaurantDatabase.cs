using Resturaunt_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;


namespace Resturaunt_Manager.DBContext
{
    public class RestaurantDatabase : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<Waiter> Waiter { get; set; }
        public DbSet<Table> Table { get; set; }



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