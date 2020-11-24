using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Models.ORM.Entities
{
    //Her departman bir fakülteye bağlı
    public class Department   : BaseEntity
    {

        [Required]
        public string Name { get; set; }

        public int FacultyID { get; set; }

        [ForeignKey("FacultyID")]
        public Faculty Faculty { get; set; }
    }
}
