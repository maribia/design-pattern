using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        
        #region abstract
        public abstract void Execute(string name);
        #endregion

        public static AbstractFactory MakeFactory(string name)
        {
            string typeName = "AbstractFactory."+ name + "Factory";
              
            Type type = Type.GetType(typeName);


            if (type != null && type.IsSubclassOf(typeof(AbstractFactory)))
            {
                return (AbstractFactory)Activator.CreateInstance(type);
            }

            System.Diagnostics.Debug.WriteLine("Factory Fail");

            return null;
        }


    }
}
