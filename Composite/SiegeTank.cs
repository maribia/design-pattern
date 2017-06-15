using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class SiegeTank : Unit
    {
        public void Attack()
        {
            System.Diagnostics.Debug.WriteLine("SiegeTank Attack");
        }

        public void Move()
        {
            System.Diagnostics.Debug.WriteLine("SiegeTank Moving");
        }
    }
}
