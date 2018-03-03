using System;
using System.Collections.Generic;
using Resturaunt_Manager.Models;

namespace Resturaunt_Manager.DTOs
{
    public class AccountDTO
    {
        
        public int Id { get; set; }
        public string Waitername { get; set; }
         public Table Table { get; set; }
        // public virutal Account {get;set;}
        public DateTime Timestamp { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
    }
}