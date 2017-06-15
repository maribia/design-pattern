using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {
        public ColorFactory()
        {
            System.Diagnostics.Debug.WriteLine("this is ColorFactory");
        }

        public override void Execute(string name)
        {

            Type type = Type.GetType("AbstractFactory." + name);
            if (type != null && type.GetInterface(typeof(IColor).Name.ToString()) != null)
            {
                IColor color = (IColor)Activator.CreateInstance(type);
                color.Color();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(name + " isn`t execute :(");
            }

            
        }
    }
}
