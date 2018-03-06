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
        public bool InStock { get; set; }

        public string SpecialInstructions { get; set; }

        public ICollection<MenuItemOptions> Options { get; set; }

        public MenuItemDTO(MenuItem item) {

            ItemID = item.ItemID;
            ItemName = item.ItemName;
            ItemDescription = item.ItemDescription;
            ItemPrice = item.ItemPrice;
            InStock = item.InStock;
            SpecialInstructions = item.SpecialInstructions;

        }

    }
}