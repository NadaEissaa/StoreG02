using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Inteface
{
    internal interface IMytype
    {
        //what can be written inside the interface
        //1. signature of method(Name , Return Type , Parameters)
        //2. signature of property
        //3. default implemented mehtod (Fully implemeted method)

        //1. signature of method(Name , Return Type , Parameters)

        void MyFun(); //Signature of method

        //2. signature of property
        double salary { get; set; }

        //3. default implemented mehtod (Fully implemeted method)

        void Print()
        {
            Console.WriteLine("HI");
        }
    }

}
