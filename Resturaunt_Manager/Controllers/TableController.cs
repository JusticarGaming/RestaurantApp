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
    public class TableController
    {
        public static Table[] GetAll()
        {
            using (var db = new RestaurantDatabase())
            {
                return db.Table.ToArray();
            }
        }

        public static async Task<Table[]> GetAllAsync()
        {
            using (var db = new RestaurantDatabase())
            {
                return await db.Table.ToArrayAsync();
            }
        }

        public static async Task<Table[]> GetByDateAsync(DateTime from, DateTime to)
        {
            using (var db = new RestaurantDatabase())
            {
                return await db.Table
                   .Where(x => x.Timestamp >= from && x.Timestamp <= to)
                   .ToArrayAsync();
            }
        }

        public static async Task<int> Create(Table table)
        {
            using (var db = new RestaurantDatabase())
            {
                db.Table.Add(table);
                await db.SaveChangesAsync();
                return table.Id;
            }
        }

        public static async Task<int> Create(Account account)
        {
            using (var db = new RestaurantDatabase())
            {
                account.Table = await db.Table.FirstAsync(x => x.Id == account.Table.Id);
                db.Table.Add(account.Table);
                await db.SaveChangesAsync();
                return account.Id;
            }
        }

        public static async Task Update(Table table)
        {
            using (var db = new RestaurantDatabase())
            {
                Waiter existing = await db.Waiter.FirstOrDefaultAsync(x => x.Id == table.Id);
                if (existing == null) { throw new KeyNotFoundException(); }
                existing.Waitername = table.Tablename;
                await db.SaveChangesAsync();
            }
        }

        public static async Task Delete(Table table)
        {
            using (var db = new RestaurantDatabase())
            {
                Table existing = await db.Table.FirstOrDefaultAsync(x => x.Id == table.Id);
                if (existing == null) { throw new KeyNotFoundException(); }
                db.Table.Remove(existing);
                await db.SaveChangesAsync();
            }
        }


    }
}