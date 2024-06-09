using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextAnimal.Model
{
    public class Leon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int? MyAnymalId { get; set; }
        public virtual MyAnymal MyAnymal { get; set; }
    }
}
