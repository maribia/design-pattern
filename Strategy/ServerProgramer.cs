using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class ServerProgramer : Programer, IServerProgramer
    {
        public abstract string Language
        {
            get;
        }

        public ServerProgramer()
        {
            server = this;
        }

        public void DisplayServerTool()
        {
            System.Diagnostics.Debug.WriteLine(Language + " is ServerTool");
        }
    }
}
