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
        private double Amount { get; set; }
        private double Tip { get; set; }
        private double Total { get; set; }
        public DateTime Timestamp { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
        [Required] public virtual Table Table { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public Account() { Timestamp = DateTime.Now; }
    }
}