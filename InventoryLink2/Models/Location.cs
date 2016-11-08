using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InventoryLink2.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [DisplayName("Location")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}