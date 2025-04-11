using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class TrueFalse : Question
    {
        public TrueFalse(string header, string body, int mark) : base(header, body, mark)
        {
        }

        public override void ShowQuestion()
        {
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }
    }

}
