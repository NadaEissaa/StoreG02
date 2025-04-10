using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //Access Modifiers : C# keyword Indicate the Accessibilty scope
    //1. private
    //2. private protected
    //3. protected
    //4. internal
    //5. internal protected
    //6. public


    //what can we write inside the namespace?
    //1. class
    //2. struct
    //3.interface
    //4. enum

    //Access modifiers can use inside the namespace is two:
    //1.Internal
    //2.public

    //what can be wrote inside the class or struct
    //1. Attributes (variables)
    //2.Methods (function)
    //3.properties (Full property - Automatic Property - Special Property [Indexer])
    public class TypeA

    {
        private int X;
        internal int Y;
        public int Z;

        void funO1()
        {
            Console.WriteLine(X);
        }


    }
}
