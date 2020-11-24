using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Models.ORM.Entities
{
    public class AdminUser : BaseEntity
    {

        [MaxLength(100)]
        public string UserName { get; set; }
        public DateTime AddDate { get; set; }
    }
}
