using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Programer1 : AllRounderProgramer
    {
        public override string ClientLangauge
        {
            get
            {
                return "Unity";
            }
        }

        public override string ServerLangauge
        {
            get
            {
                return "php";
            }
        }
    }
}
