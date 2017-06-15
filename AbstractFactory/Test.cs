using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace AbstractFactory
{
    [TestFixture]
    public class Test : IExecute
    {


        [Test]
        public void Execute()
        {
            {
                AbstractFactory factory = AbstractFactory.MakeFactory("Color");
                factory.Execute("Red");
                factory.Execute("Green");
                factory.Execute("Red");
                factory.Execute("Circle");
                factory.Execute("Square");
                factory.Execute("Rectangle");
            }

            {
                AbstractFactory factory = AbstractFactory.MakeFactory("Shape");
                factory.Execute("Red");
                factory.Execute("Green");
                factory.Execute("Red");
                factory.Execute("Circle");
                factory.Execute("Square");
                factory.Execute("Rectangle");
            }

        }


    }
}
