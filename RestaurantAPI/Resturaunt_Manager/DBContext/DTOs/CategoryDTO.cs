using Resturaunt_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.DTOs {
    public class CategoryDTO {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public CategoryDTO(Category value) {
            CategoryID = value.CategoryID;
            CategoryName = value.CategoryName;
        }
    }
}