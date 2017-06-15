using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Employee : IEmployee
    {
        string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public void Smile()
        {
            System.Diagnostics.Debug.WriteLine("Employee " + name + " is smile");
        }
    }
}
