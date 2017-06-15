using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public ShapeFactory()
        {
            System.Diagnostics.Debug.WriteLine("this is ShapeFactory");
        }

        public override void Execute(string name)
        {
            Type type = Type.GetType("AbstractFactory." + name);
            if(type == null)
                System.Diagnostics.Debug.WriteLine("shit" + name);

            if (type != null && type.GetInterface(typeof(IShape).Name.ToString()) != null)
            {
                IShape shape = (IShape)Activator.CreateInstance(type);
                shape.draw();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(name + " isn`t execute :(");
            }

            
        }
    }
}
