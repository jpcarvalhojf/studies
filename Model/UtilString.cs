using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos.Model
{
    public class UtilString
    {
        internal void CompareString(string s1)
        {
            if (s1.Equals("JOAO"))
            {
                Console.WriteLine("TEM MEU NOME");
            }
            else
            {
                Console.WriteLine("MEU NOME NAO ESTÁ AQUI");
            }
        }
    }
}
