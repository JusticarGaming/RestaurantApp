using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class MenuItem
    {
        public Guid ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public virtual ICollection<MenuItem> Items { get; set; }

    }
}