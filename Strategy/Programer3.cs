using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Programer3 : ServerProgramer
    {
        public override string Language
        {
            get
            {
                return "python";
            }
        }
    }
}
