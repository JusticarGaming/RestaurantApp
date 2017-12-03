using Resturaunt_Manager.DTOs;
using Resturaunt_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Resturaunt_Manager.DBContext;
using System.Data.Entity;

namespace Resturaunt_Manager.Controllers
{
    public class AccountController
    {
        public static Account[] GetAll()
        {
            using (var db = new RestaurantDatabase())
            {
                return db.Account.ToArray();
            }
        }

        public static async Task<Account[]> GetAllAsync()
        {
            using (var db = new RestaurantDatabase())
            {
                return await db.Account.ToArrayAsync();
            }
        }

        public static async Task<Account[]> GetByDateAsync(DateTime from, DateTime to)
        {
            using (var db = new RestaurantDatabase())
            {
                return await db.Account
                   .Where(x => x.Timestamp >= from && x.Timestamp <= to)
                   .ToArrayAsync();
            }
        }
    }
}