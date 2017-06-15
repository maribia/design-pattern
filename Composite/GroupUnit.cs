using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class GroupUnit : Unit
    {
        List<Unit> unitList = new List<Unit>();

        public void Attack()
        {
            foreach(Unit unit in unitList)
            {
                unit.Attack();
            }
        }

        public void Move()
        {
            foreach (Unit unit in unitList)
            {
                unit.Move();
            }
        }

        public void Add(Unit unit)
        {

            unitList.Add(unit);
        }

        public void Remove(Unit unit)
        {
            unitList.Remove(unit);
        }
    }
}
