using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace InventoryLink2.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [DisplayName("ID")]
        [Required]
        [StringLength(180)]
        public string ProductIdExternal { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Stock { get; set; }

        [DisplayName("Attribute 1")]
        public int? ProductAttribute1 { get; set; }

        [DisplayName("Attribute 2")]
        public int? ProductAttribute2 { get; set; }

        [DisplayName("Attribute A")]
        [StringLength(180)]
        public string ProductAttributeA { get; set; }

        [DisplayName("Attribute B")]
        [StringLength(180)]
        public string ProductAttributeB { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int LocationId { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }

        [JsonIgnore]
        public virtual Location Location { get; set; }
    }
}