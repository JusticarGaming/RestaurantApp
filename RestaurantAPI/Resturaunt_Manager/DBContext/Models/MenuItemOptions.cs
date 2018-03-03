using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models {
    public class MenuItemOptions {

        [Key] public Guid Id { get; set; }
        public string OptionDescription { get; set; }
        public virtual ICollection<MenuItemOptionOptions> PossibleSelections { get; set; }        

    }
}