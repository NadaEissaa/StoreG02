using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EXAM02
{
    public class ExamService
    {
        public void Run()
        {
            try
            {
                PrintHeader("Welcome to the Examination System!");

                PrintSection("Select Exam Type");
                Console.WriteLine("1. Practical");
                Console.WriteLine("2. Final");
                int examType = GetValidChoice(2);

                PrintSection("Enter Exam Details");
                Console.Write("Exam time (positive integer in minutes): ");
                int examTime = GetValidIntInput();

                Console.Write("Number of questions: ");
                int numQuestions = GetValidIntInput();

                Exam exam = examType == 1
                    ? new PracticalExam($"{examTime} minutes", numQuestions)
                    : new FinalExam($"{examTime} minutes", numQuestions);

                for (int i = 0; i < numQuestions; i++)
                {
                    PrintSubsection($"Entering Question {i + 1}");
                    Question question = CreateQuestion(exam, i + 1);
                    exam.Questions.Add(question);
                }

              
                PrintSection("Exam Creation Completed");
                Subject subject = new Subject("Example Subject");
                subject.CreateExam(exam);

                
                Console.WriteLine("\nDo you want to start the exam? (yes/no): ");
                string start = Console.ReadLine()?.ToLower() ?? string.Empty;

                if (start == "yes")
                {
                    ConductExam(exam);
                }
                else if (start == "no")
                {
                    PrintFooter("Exam cancelled. Goodbye!");
                }
                else
                {
                    PrintFooter("Invalid input. Exiting...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred: {ex.Message}");
            }
        }

        private int GetValidIntInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            return input;
        }

        private int GetValidChoice(int maxOption)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > maxOption)
            {
                Console.WriteLine($"Invalid choice. Please enter a number between 1 and {maxOption}.");
            }
            return choice;
        }

        private Question CreateQuestion(Exam exam, int questionNumber)
        {
            string body;
            do
            {
                Console.Write("Enter question body: ");
                body = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(body))
                {
                    Console.WriteLine("Question body cannot be null or empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(body));

            Console.Write("Enter question mark: ");
            int mark = GetValidIntInput();

            if (exam is FinalExam)
            {
                return CreateFinalExamQuestion(body, mark, questionNumber);
            }

            Question question = new MCQ($"[MCQ] Question {questionNumber}: ", body, mark);
            AddAnswers(question);
            return question;
        }

        private Question CreateFinalExamQuestion(string body, int mark, int questionNumber)
        {
            PrintSection("Select Question Type");
            Console.WriteLine("1. MCQ");
            Console.WriteLine("2. True/False");
            int questionType = GetValidChoice(2);

            if (questionType == 1)
            {
                Question question = new MCQ($"[MCQ] Question {questionNumber}: ", body, mark);
                AddAnswers(question);
                return question;
            }

            Console.Write("Enter the correct answer (1 for True, 2 for False): ");
            int correctAnswer = GetValidChoice(2);

            TrueFalse trueFalseQuestion = new($"[True/False] Question {questionNumber}: ", body, mark)
            {
                CorrectAnswerId = correctAnswer
            };
            trueFalseQuestion.AddAnswer(new Answer(1, "True"));
            trueFalseQuestion.AddAnswer(new Answer(2, "False"));
            return trueFalseQuestion;
        }

        private void AddAnswers(Question question)
        {
            PrintSection("Add Answers");
            Console.Write("Enter the number of answers (at least 2): ");
            int numAnswers = GetValidIntInput();

            for (int i = 0; i < numAnswers; i++)
            {
                string answerText;
                do
                {
                    Console.Write($"Enter Answer {i + 1} Text: ");
                    answerText = Console.ReadLine() ?? string.Empty;

                    if (string.IsNullOrWhiteSpace(answerText))
                    {
                        Console.WriteLine("Answer text cannot be null or empty. Please try again.");
                    }
                } while (string.IsNullOrWhiteSpace(answerText));

                question.AddAnswer(new Answer(i + 1, answerText));
            }

            Console.Write("Enter the ID of the correct answer: ");
            question.CorrectAnswerId = GetValidChoice(question.AnswerList.Count);
        }

        private void ConductExam(Exam exam)
        {
         
            Console.Clear();

          
            PrintHeader("Starting the Exam");
            List<int> userAnswers = new();
            Stopwatch stopwatch = Stopwatch.StartNew();

           
            foreach (var question in exam.Questions)
            {
                PrintSubsection($"{question.Header} {question.Body} (Mark: {question.Mark})");
                question.ShowQuestion();

               
                int userAnswerId = GetValidChoice(question.AnswerList.Count);
                userAnswers.Add(userAnswerId);
            }

          
            stopwatch.Stop();

           
            if (exam is PracticalExam)
            {
                PrintSection("Practical Exam Results");
                DisplayPracticalResults(exam);
                Console.WriteLine($"\nTime Taken: {stopwatch.Elapsed.TotalMinutes:F2} minutes");
            }
            else if (exam is FinalExam)
            {
                PrintSection("Final Exam Results");
                DisplayFinalResults(exam, userAnswers);
                Console.WriteLine($"\nTime Taken: {stopwatch.Elapsed.TotalMinutes:F2} minutes");
            }

         
            PrintFooter("Exam Completed. Thank you!");
        }

        private void DisplayPracticalResults(Exam exam)
        {
            foreach (var question in exam.Questions)
            {
                Console.WriteLine($"\n{question.Header} {question.Body}");
                foreach (var answer in question.AnswerList)
                {
                    if (answer.AnswerId == question.CorrectAnswerId)
                    {
                        Console.WriteLine($"Correct Answer: {answer.AnswerText}");
                    }
                }
            }
        }

        private void DisplayFinalResults(Exam exam, List<int> userAnswers)
        {
            foreach (var question in exam.Questions)
            {
                Console.WriteLine($"\n{question.Header} {question.Body}");
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }
                Console.WriteLine($"Correct Answer ID: {question.CorrectAnswerId}");
            }

            int totalMarks = exam.Questions.Sum(q => q.Mark);
            int grade = exam.GradeExam(userAnswers);
            Console.WriteLine($"\nYour Total Grade: {grade}/{totalMarks}");
        }

        private void PrintHeader(string title)
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine($"        {title}");
            Console.WriteLine("==================================\n");
        }

        private void PrintSection(string section)
        {
            Console.WriteLine($"\n--- {section} ---\n");
        }

        private void PrintSubsection(string subsection)
        {
            Console.WriteLine($"\n>>> {subsection} <<<\n");
        }

        private void PrintFooter(string message)
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine($"        {message}");
            Console.WriteLine("==================================\n");
        }
    }
}
