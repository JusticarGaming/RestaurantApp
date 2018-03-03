using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class MenuItem
    {
        [Key] public Guid ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public bool InStock { get; set; }

        public string SpecialInstructions { get; set; }

        public virtual ICollection<MenuItemOptions>  Options { get; set; }


        //public virtual ICollection<MenuItem> Items { get; set; }
        //public List<string> ExtrasList { get; set; }

    }
}