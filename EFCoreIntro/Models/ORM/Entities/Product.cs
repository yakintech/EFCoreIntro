﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Models.ORM.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
