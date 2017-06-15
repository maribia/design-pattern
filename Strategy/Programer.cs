using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Programer
    {

        protected IClientProgramer client;
        protected IServerProgramer server;



        public void Display()
        {
            if (client != null)
                client.DisplayClientTool();
            if (server != null)
                server.DisplayServerTool();
        }
        
    }
}
