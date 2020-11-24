using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Models.ORM.Entities
{
    public class Faculty : BaseEntity
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }
}
