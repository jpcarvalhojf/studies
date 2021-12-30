using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos.Model
{
    public class DelegateEstudo
    {
        public delegate void Del(string message);

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public void invokeDelegate()
        {
            Del handler = DelegateMethod;            
            handler("Iniciei...");
        }
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        

        public void MultiCastDelegate(string s)
        {
            var utilString = new UtilString();
            Del d1 = DelegateMethod;
            Del d2 = utilString.CompareString;
            Del multiCastHandler = d1 + d2;

            multiCastHandler(s);
        }
    }
}
