using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Composite
{
    [TestFixture]
    class Test
    {

        [Test]
        public void TestExecute()
        {
            GroupUnit group = new GroupUnit();
            for(int i = 0; i < 3; i++)
            {
                Marine marine = new Marine();
                SiegeTank siege = new SiegeTank();
                group.Add(marine);
                group.Add(siege);
            }

            group.Attack();
            group.Move();
        }
    }
}
