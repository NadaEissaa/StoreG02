using AssignmentEFC_2.Context;
using AssignmentEFC_2.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssignmentEFC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContexxt())
            {



                // Insert Department
                //var department = new Department { Name = "Information System", Ins_ID = 1, HiringDate = DateTime.Now };
                //context.Departments.Add(department);
                //context.SaveChanges();

                //// Insert Instructor
                //var instructor = new Instructor { Name = "Dr. Smith", Salary = 5000, Address = "456 MAADI", HourRateBonus = 50, Dept_ID = department.ID };
                //context.Instructors.Add(instructor);
                //context.SaveChanges();

                //// Insert Course
                //var course = new Course { Name = "C# Programming", Duration = 30, Description = "Learn C# from scratch" };
                //context.Courses.Add(course);
                //context.SaveChanges();

                // Insert Student
                //var student = new Student { FName = "Nada", LName = "Eissa", Address = "123 Street", Age = 20, Dep_Id = department.ID };
                //context.Students.Add(student);
                //context.SaveChanges();

                //// Insert Topic
                //var topic = new Topic { Name = "Object-Oriented Programming" };
                //context.Topics.Add(topic);
                //context.SaveChanges();

                //// Insert Student-Course
                //var studentCourse = new Stud_Course { Stud_ID = student.ID, Course_ID = course.ID, Grade = 95 };
                //context.Stud_Courses.Add(studentCourse);
                //context.SaveChanges();

                //// Insert Course-Instructor Assignment
                //var courseInst = new Course_Inst { Inst_ID = instructor.ID, Course_ID = course.ID, Evaluate = "Excellent" };
                //context.Course_Instructors.Add(courseInst);
                //context.SaveChanges();

                ////Read
                ///

                //var students = context.Students.Include(s => s.Department).ToList();
                //foreach (var s in students)
                //{
                //    Console.WriteLine($"Student: {s.FName} {s.LName}, Department: {s.Department?.Name}");
                //}

                //var courses = context.Courses.ToList();
                //foreach (var c in courses)
                //{
                //    Console.WriteLine($"Course: {c.Name}, Description: {c.Description}");
                //}

                //Update

                //var studentToUpdate = context.Students.FirstOrDefault(s => s.ID == student.ID);
                //if (studentToUpdate != null)
                //{
                //    studentToUpdate.Address = "789 New Street";
                //    context.SaveChanges();
                //}


                //var courseToUpdate = context.Courses.FirstOrDefault(c => c.ID == course.ID);
                //if (courseToUpdate != null)
                //{
                //    courseToUpdate.Description = "Advanced C# Concepts";
                //    context.SaveChanges();
                //}

                //  DELETE 
                //var studentToDelete = context.Students.FirstOrDefault(s => s.ID == student.ID);
                //if (studentToDelete != null)
                //{
                //    context.Students.Remove(studentToDelete);
                //    context.SaveChanges();
                //}

                //var courseToDelete = context.Courses.FirstOrDefault(c => c.ID == course.ID);
                //if (courseToDelete != null)
                //{
                //    context.Courses.Remove(courseToDelete);
                //    context.SaveChanges();
                //}


            }
        } 
    }
}

