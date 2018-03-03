using Resturaunt_Manager.DBContext;
using Resturaunt_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Resturaunt_Manager.Controllers
{
    public class WaiterController
    {

        public static Waiter[] GetAll()
        {
            using (var db = new RestaurantDatabase())
            {
                return db.Waiter.ToArray();
            }
        }

        public static async Task<Waiter[]> GetAllAsync()
        {
            using (var db = new RestaurantDatabase())
            {
                return await db.Waiter.ToArrayAsync();
            }
        }

        public static async Task<Waiter[]> GetByDateAsync(DateTime from, DateTime to)
        {
            using (var db = new RestaurantDatabase())
            {
                return await db.Waiter
                   .Where(x => x.Timestamp >= from && x.Timestamp <= to)
                   .ToArrayAsync();
            }
        }

        public static async Task<int> Create(Waiter waiter)
        {
            using (var db = new RestaurantDatabase())
            {
                db.Waiter.Add(waiter);
                await db.SaveChangesAsync();
                return waiter.Id;
            }
        }

        public static async Task<int> Create(Table table)
        {
            using (var db = new RestaurantDatabase())
            {
                table.Waiter= await db.Waiter.FirstAsync(x => x.Id == table.Waiter.Id);
                db.Table.Add(table);
                await db.SaveChangesAsync();
                return table.Id;
            }
        }

        public static async Task Update(Waiter waiter)
        {
            using (var db = new RestaurantDatabase())
            {
                Waiter existing = await db.Waiter.FirstOrDefaultAsync(x => x.Id == waiter.Id);
                if (existing == null) { throw new KeyNotFoundException(); }
                existing.Waitername = waiter.Waitername;
                await db.SaveChangesAsync();
            }
        }

        public static async Task Delete(Waiter waiter)
        {
            using (var db = new RestaurantDatabase())
            {
                Waiter existing = await db.Waiter.FirstOrDefaultAsync(x => x.Id == waiter.Id);
                if (existing == null) { throw new KeyNotFoundException(); }
                db.Waiter.Remove(existing);
                await db.SaveChangesAsync();
            }
        }

        public static async Task<Table[]> GetTableList(int waiterid)
      {
         using (var db = new RestaurantDatabase())
         {
            return await db.Table
               .Where(x => x.Waiter.Id == waiterid)
               .ToArrayAsync();
         }
      }

      public static async Task<List<Account>> GetAccountList(int waiterid)
      {
         using (var db = new RestaurantDatabase())
         {
            List<Account> accounts = await db.Account.Where(x => x.Waiterid == waiterid).ToListAsync();
            if (accounts == null) { throw new KeyNotFoundException(); }
            return accounts.ToList();
         }
      }
    }
}