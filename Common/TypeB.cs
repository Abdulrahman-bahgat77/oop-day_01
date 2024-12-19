using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        // typeB is accessable within its project Only.
        public TypeB()
        {
            TypeA TypeA = new TypeA();
            //TypeA.x = 10; //invalid x is private

            //TypeA.y = 20; // valid y is internal

            TypeA.z = 30;

        }
    }
}
