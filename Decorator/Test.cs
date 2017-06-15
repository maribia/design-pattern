using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Decorator
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Execute()
        {
            IDraw draw = new Red(new Yellow(new Blue(new Blue(new Blue(new Red(null))))));
            draw.Draw();
        }
    }
}
