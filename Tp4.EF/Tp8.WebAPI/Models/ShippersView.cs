using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tp8.WebAPI.Models
{
    public class ShippersView
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(40)]
        public string name { get; set; }

        [StringLength(24)]
        public string phone { get; set; }
    }
}