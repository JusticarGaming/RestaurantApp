using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public int WaiterId { get; set; }
        public double Amount { get; set; }
        public double Tip { get; set; }

        public double Total { get; set; }

        public DateTime Timestamp { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
        [Required] public virtual Table Table { get; set; }

        //public virtual ICollection<Account> Accounts { get; set; }

        public virtual ICollection<AccountOrderItem> OrderedItems { get; set; }

        public Account() {
            //rather do the timestamp after creating the new account, afaik this constructor is gonna get called even when it is loading existing items from DB
        }
    }
}