using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groups.Model
{
    public class AnimalGroup
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }

    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }
    }
}
