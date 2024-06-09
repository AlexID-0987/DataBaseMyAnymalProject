using DataContextAnimal.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextAnimal.MYContext
{
    class MyAnimalContext:DbContext
    {
        public MyAnimalContext():base("name=DB")
        {

        }
        public virtual DbSet<MyAnymal> MyAnymals { get; set; }
        public virtual DbSet<Leon> Leons { get; set; }
    }
}
