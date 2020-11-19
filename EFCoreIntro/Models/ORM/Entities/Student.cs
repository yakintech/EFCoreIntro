﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Models.ORM.Entities
{
    public class Student
    {
        //ID özel bir kelime. Bu sayede default olarak primarykey oluyor
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
