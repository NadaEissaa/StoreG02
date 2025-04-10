using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class PracticalExam : Exam
    {
        public PracticalExam(string? time, int numQuestions)
            : base(time ?? throw new ArgumentNullException(nameof(time), "Exam time cannot be null."), numQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam Completed! Here are the correct answers:");
            foreach (var question in Questions)
            {
                Console.WriteLine($"\nQuestion: {question.Body}");
                Console.WriteLine($"Correct Answer: {question.CorrectAnswerId}");
            }
        }
    }
}
