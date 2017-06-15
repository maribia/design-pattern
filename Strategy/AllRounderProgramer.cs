using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class AllRounderProgramer : Programer, IClientProgramer, IServerProgramer
    {
        public abstract string ServerLangauge
        {
            get;
        }

        public abstract string ClientLangauge
        {
            get;
        }

        public AllRounderProgramer()
        {
            server = this;
            client = this;
        }

        public void DisplayClientTool()
        {
            System.Diagnostics.Debug.WriteLine(ClientLangauge + " is ClientTool");
        }

        public void DisplayServerTool()
        {
            System.Diagnostics.Debug.WriteLine(ServerLangauge + " is ServerTool");
        }
    }
}
