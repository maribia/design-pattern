using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Consultant : IEmployee
    {
        string name;

        public Consultant(string name)
        {
            this.name = name;
        }

        public void Happiness()
        {
            System.Diagnostics.Debug.WriteLine("Consultant " + name + " is smile");
        }

        public void Smile()
        {
            this.Happiness();
        }
    }
}
