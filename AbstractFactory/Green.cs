using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Green : IColor
    {
        public void Color()
        {
            System.Diagnostics.Debug.WriteLine("Color is Green");
        }
    }
}
