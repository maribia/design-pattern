using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Adapter
{
    [TestFixture]
    public class Test
    {
        List<IEmployee> employeeList = new List<IEmployee>();
        [Test]
        public void Execute()
        {
            for(int i = 0; i < 5; i++)
            {
                employeeList.Add(new Employee(i.ToString()));
                employeeList.Add(new Consultant(i.ToString()));
            }

            foreach(IEmployee employee in employeeList)
            {
                employee.Smile();
            }
        }

    }
}
