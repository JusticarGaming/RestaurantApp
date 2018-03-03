using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class Category
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<MenuItem> Items { get; set; }
    }
}