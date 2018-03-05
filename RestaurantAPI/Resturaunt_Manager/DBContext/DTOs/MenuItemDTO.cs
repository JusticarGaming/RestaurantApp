using Resturaunt_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.DTOs {
    public class MenuItemDTO {

        public Guid ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public virtual ICollection<MenuItemDTO> Items { get; set; }
        public List<string> ExtrasList { get; set; }

        public MenuItemDTO(MenuItem item) {

            ItemID = item.ItemID;
            ItemName = item.ItemName;
            ItemDescription = item.ItemDescription;
            ItemPrice = item.ItemPrice;
            //Items = item.Items.Select(x => new MenuItemDTO(x)).ToList();
            //ExtrasList = item.ExtrasList;

        }

    }
}