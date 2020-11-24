using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Models.ORM.Entities
{
    public class Course  : BaseEntity
    {
        public string Name { get; set; }
    }
}
