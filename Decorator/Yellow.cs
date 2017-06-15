using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Yellow : IDraw
    {
        IDraw child;

        public Yellow(IDraw child)
        {
            this.child = child;
        }

        public void Draw()
        {
            System.Diagnostics.Debug.WriteLine("Yellow");
            if (child != null)
                child.Draw();
        }
    }
}
