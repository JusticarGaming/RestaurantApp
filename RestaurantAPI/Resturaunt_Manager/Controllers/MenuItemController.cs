using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Http;
using Resturaunt_Manager.Models;
using System.Threading.Tasks;
using Resturaunt_Manager.DBContext;
using System.Data.Entity;
using Resturaunt_Manager.DTOs;

namespace Resturaunt_Manager.Controllers
{
    public class MenuItemController : ApiController
    {

        [HttpGet]
        [Route("api/menu/{categoryId}")]
        public async Task<List<MenuItemDTO>> GetItemsInCategory(Guid categoryId) {

            using (var db = new RestaurantDatabase()) {
                var cat = await db.Categories.Where(x => x.CategoryID == categoryId).FirstOrDefaultAsync();
                if (cat == null) {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
                return cat.Items.Select(x => new MenuItemDTO(x)).ToList();
            }

        }

        [HttpPost]
        [Route("api/menu/addcategory")]
        public async Task<CategoryDTO> AddCategory(string CategoryName) {

            using (var db = new RestaurantDatabase()) {
                var cat = new Category() {
                    CategoryName = CategoryName,
                    CategoryID = Guid.NewGuid(),
                    Items = new List<MenuItem>(),
                };
                db.Categories.Add(cat);
                await db.SaveChangesAsync();
                return new CategoryDTO(cat);
            }

        }

        [HttpPost]
        [Route("api/menu/{categoryId}/addItem")]
        public async Task<CategoryDTO> AddCategory(string CategoryName, [FromBody] MenuItemDTO item) {

            using (var db = new RestaurantDatabase()) {
                var cat = new Category() {
                    CategoryName = CategoryName,
                    CategoryID = Guid.NewGuid(),
                    Items = new List<MenuItem>(),
                };
                db.Categories.Add(cat);
                await db.SaveChangesAsync();
                return new CategoryDTO(cat);
            }

        }

    }
}