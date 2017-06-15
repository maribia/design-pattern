using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Marine : Unit
    {
        public void Attack()
        {
            System.Diagnostics.Debug.WriteLine("Marine Attack");
        }

        public void Move()
        {
            System.Diagnostics.Debug.WriteLine("Marine Moving");
        }
    }
}
