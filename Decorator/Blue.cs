using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Blue : IDraw
    {
        IDraw child;

        public Blue(IDraw child)
        {
            this.child = child;
        }

        public void Draw()
        {
            System.Diagnostics.Debug.WriteLine("Blue");
            if (child != null)
                child.Draw();
        }
    }
}
