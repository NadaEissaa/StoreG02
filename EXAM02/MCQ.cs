using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class MCQ : Question
    {
        public MCQ(string header, string body, int mark) : base(header, body, mark)
        {
        }

        public override void ShowQuestion()
        {
            for (int i = 0; i < AnswerList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
            }
        }
    }
}
