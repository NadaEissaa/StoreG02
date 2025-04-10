using EFC_Session.Contexts;
using EFC_Session.Entities;
using System;

namespace EFC_Session
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AppDbContext context = new AppDbContext();

            //try
            //{

            ////CRUD OP on DB
            //}
            //finally{
            ////code
            ////context.Dispose();
            //}

            //using(AppDbContext context = new AppDbContext)){
            ////operation
            //}

            //using AppDbContext context = new AppDbContext(); //unmanged resourse

            #region CRUD OPERATIONS
            //CRUD OPERATIONS

            #region Create | Insert

            //AppDbContext Context = new AppDbContext();

            //try
            //{

            //}
            //finally
            //{
            //    Context.Dispose();
            //}

            //using AppDbContext context = new AppDbContext();

            //var employee = new Employee()
            //{
            //    Name = "Ahmed Ali",
            //    Salary = 12000,
            //    Address = "Cairo",

            //};

            //context.Employees.Add(employee);
            //context.SaveChanges();



            #endregion


            #region Read | Select

            // Read | Select

            //var result = context.Employees.Where(E => E.Id == 20).FirstOrDefault();

            //  Console.WriteLine(result);


            //foreach( var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Update
            // Update

            //var result = context.Employees.find(10);

            //result.Age = 12;

            //int count = context.SaveChanges();
            //Console.WriteLine(count);
            #endregion


            #region Delete

            // Delete
            //var result = context.Employee.Find(10);
            //Console.WriteLine(context.Entry(result).State);

            //context.Employees.Remove();
            //context.SaveChanges();
            //onsole.WriteLine(context.Entry(result).State);

            //var result =   context.Employees.Where(E => E.Age == 30);
            //   foreach(var item in resutl)
            //   {
            //       Console.WriteLine(item);
            //       context.Remove(item);
            //   }
            //   context.SaveChanges();

            //context.RemoveRange(result);
            #endregion
            #endregion

            //using AppDbContext context = new AppDbContext();


        }
    }
}
