using System;

namespace EXAM02
{
    public class FinalExam : Exam
    {
        public FinalExam(string? time, int numQuestions)
            : base(time ?? throw new ArgumentNullException(nameof(time), "Exam time cannot be null."), numQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam Completed! Here are the correct answers:");
            foreach (var question in Questions)
            {
                Console.WriteLine($"\nQuestion: {question.Body}");
                foreach (var answer in question.AnswerList)
                {
                    if (answer.AnswerId == question.CorrectAnswerId)
                    {
                        Console.WriteLine($"Correct Answer: {answer.AnswerText}");
                    }
                }
            }
        }
    }
    }
