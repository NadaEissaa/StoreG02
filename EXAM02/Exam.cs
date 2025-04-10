using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public abstract class Exam
    {
        public string Time { get; set; }
        public int NumQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(string time, int numQuestions)
        {
            Time = time;
            NumQuestions = numQuestions;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();

        public int GradeExam(List<int> userAnswers)
        {
            int totalScore = 0;
            for (int i = 0; i < Questions.Count; i++)
            {
                if (Questions[i].CorrectAnswerId == userAnswers[i])
                {
                    totalScore += Questions[i].Mark;
                }
            }
            return totalScore;
        }

        public override string ToString()
        {
            return $"Exam with {NumQuestions} Questions (Time: {Time})";
        }
    }

}
