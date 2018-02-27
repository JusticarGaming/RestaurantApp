﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class Waiter
    {
        [Key]
        public int Id { get; set; }
        public string Waitername { get; set; }
        [Required]public Table Table{get;set;}
        // public virutal Account {get;set;}
        public DateTime Timestamp { get; set; }

        public virtual ICollection<Table> Tables { get; set; }

        public Waiter() { Timestamp = DateTime.Now; }

    }
}