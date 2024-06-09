﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextAnimal.Model
{
    public class MyAnymal
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Leon> Leons { get; set; } = new HashSet<Leon>();
    }
}
