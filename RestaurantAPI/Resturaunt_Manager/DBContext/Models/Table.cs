using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public string Tablename { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }        
        [Required] public virtual Waiter Waiter { get; set; }

        
    }
}