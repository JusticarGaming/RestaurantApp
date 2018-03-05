using Resturaunt_Manager.DTOs;
using Resturaunt_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Resturaunt_Manager.DBContext;
using System.Data.Entity;
using System.Net;
using System.Web.Http;

namespace Resturaunt_Manager.Controllers
{
    public class AccountController : ApiController
    {
        public Account[] GetAll()
        {
            using (var db = new RestaurantDatabase())
            {
                return db.Account.ToArray();
            }
        }
        [HttpGet]
        [Route("api/Account/all")]
        public async Task<Account[]> GetAllAsync()
        {
            using (var db = new RestaurantDatabase())
            {
                return await db.Account.ToArrayAsync();
            }
        }

        [HttpGet]
        [Route("api/Account/{Datefrom,DateTo}")]
        public async Task<Account[]> GetByDateAsync(DateTime from, DateTime to)
        {
            using (var db = new RestaurantDatabase())
            {
                return await db.Account
                   .Where(x => x.Timestamp >= from && x.Timestamp <= to)
                   .ToArrayAsync();
            }
        }

        //public static async Task<int> Create(Table table)
        //{
        //    using (var db = new RestaurantDatabase())
        //    {
        //        db.Table.Add(table);
        //        await db.SaveChangesAsync();
        //        return table.Id;
        //    }
        //}

        //public static async Task<int> Create(Account account)
        //{
        //    using (var db = new RestaurantDatabase())
        //    {
        //        account.Table = await db.Table.FirstAsync(x => x.Id == account.Table.Id);
        //        db.Table.Add(account.Table);
        //        await db.SaveChangesAsync();
        //        return account.Id;
        //    }
        //}

        [HttpPost]
        [Route("api/Account/Update")]
        public async Task Update(Account account)
        {
            using (var db = new RestaurantDatabase())
            {
                Account existing = await db.Account.FirstOrDefaultAsync(x => x.Id == account.Id);
                if (existing == null) { throw new HttpResponseException(HttpStatusCode.NotFound); }
                existing.Amount = account.Amount;
                await db.SaveChangesAsync();
            }
        }

        public async Task Delete(Account account)
        {
            using (var db = new RestaurantDatabase())
            {
                Account existing = await db.Account.FirstOrDefaultAsync(x => x.Id == account.Id);
                if (existing == null) { throw new HttpResponseException(HttpStatusCode.NotFound); }
                db.Account.Remove(existing);
                await db.SaveChangesAsync();
            }
        }
    }
}