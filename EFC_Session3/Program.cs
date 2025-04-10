using EFC_Session3.Context;
using EFC_Session3.Entities;

namespace EFC_Session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 ways to Generate Schema

            //1.Tpc
            //2.TPH
            //3.TPCC

            using AppDbContext context = new AppDbContext();

            FullTimeEmployee fullTime = new FullTimeEmployee()
            {
                Name = "Nada Eissa",
                Address = "Gize",
                Email = "Nada@gmail",
                Salary = 18000
            };
            context.FullTimeEployeesm.Add(fullTime);

            //context.SaveChanges();


            //var result = context.Employee.OfType<FullTimeEmployee>();

            //foreach(var item in fullTime)
            //{
            //    Console.WriteLine(item.Name);
            //}


        }
    }
}
