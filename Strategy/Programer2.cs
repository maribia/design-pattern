using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Programer2 : ClientProgramer
    {
        public override string Language
        {
            get
            {
                return "c++";
            }
        }
    }
}
