using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models {
    public class MenuItemOptionOptions {
        [Key] public Guid Id { get; set; }
        public string Option { get; set; }
    }
}