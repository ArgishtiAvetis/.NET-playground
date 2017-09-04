using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Model
{
    class Car
    {
        public int Born { get; set; }
        public string Name { get; set; }

        public Car() { }

        public Car(string name, int born)
        {
            this.Name = name;
            this.Born = born;
        }

        public override string ToString()
        {
            return Name + " | Manufactured in " + Born;
        }
    }
}
