using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Inteface
{
    internal class MyType : IMytype
    {

        public double Salay { get; set; } //Automactic prop
        public double salary
        {
            get { throw new NotImplementedException(); }

            set { throw new NotImplementedException(); }
        }
        public void MyFun()
        {
            Console.WriteLine("HELLO");
        }
    }
}
