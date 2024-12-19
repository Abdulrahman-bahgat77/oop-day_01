using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // accessable in this project and within external project[import]
    public class TypeA
    {
        ///       What You Can Write Inside The Struct Or Class
        ///1. Attributes[Fields] => Member Variable  
        ///2. Functions[Constructor, Getter Setter, Method]
        ///3. Properties[Full Property, Automatic Property, Indexer]
        ///4. Events


        ///        Access Modifier Allowed Inside Class?
        ///Private[Default]
        ///Private Protected
        ///Protected
        ///Internal
        ///Protected Internal
        ///Public

        private int x; // accessable in its scope only
       internal int y; // accessable within its scope and its project
       public int z; // accessable witin its sciope and   project [import]

        void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
