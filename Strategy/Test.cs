using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Strategy
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Execute()
        {
            new Programer1().Display();
            new Programer2().Display();
            new Programer3().Display();
        }
    }
}
