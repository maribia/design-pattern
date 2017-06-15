using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Red : IDraw
    {
        IDraw child;

        public Red(IDraw child)
        {
            this.child = child;
        }

        public void Draw()
        {
            System.Diagnostics.Debug.WriteLine("Red");
            if (child != null)
                child.Draw();
        }
    }
}
