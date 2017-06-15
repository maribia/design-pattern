using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class ClientProgramer : Programer, IClientProgramer
    {
        public abstract string Language
        {
            get;
        }

        public ClientProgramer()
        {
            client = this;
        }

        public void DisplayClientTool()
        {
            System.Diagnostics.Debug.WriteLine(Language + " is ClientTool");
        }
    }
}
