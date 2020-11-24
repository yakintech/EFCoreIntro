using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Models.VM
{
    public class ProductSearchVM
    {
        [Required]
        public string name { get; set; }

        [Required]
        public decimal minprice { get; set; }

        [Required]
        public decimal maxprice { get; set; }

    }
}

