using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01CSharp_Jun
{
    internal class SomeClass
    {
        int someVaule = 10;
        public ref int someMathod()
        {
            return ref someVaule;
        }
    }
}
