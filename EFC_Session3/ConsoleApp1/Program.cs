using ConsoleApp1.Context;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ef Core loading Navigational property
            // Explicit loadinge
            // Eager Loading
            // Lazy loading


            //1. Explict loading

            //.Reference().Load()

            //2. Eager loading


            //using include() ,then the name of the navigation propert

            //3. Lazy loading //Best
            //3.1 Install package Proxies
            //3.2 Update OnConfiguraing(), UseLazyLoadingProxies
            //3.3 Make All Entites Public
            //3.4 Make All Navigational Properties Virtual


            // Join Operators - Join
            //Fluent syntax
            //  using FirstDbContext context = new FirstDbContext();
            //var result =  context.Employees.Join(context.Departments, E => E.Id, D => D.Id, (E, D) => new
            //  {
            //      EmpId = E.Id,
            //      DepId = D.Id,
            //      EmpName = E.Name,
            //      DeptName = D.DeptName

            //  });

            //  //Query Syntax
            //  result = from E in context.Employees
            //           join D in context.Departments
            //           on E.Id equals D.Id
            //           select new
            //           {
            //               EmpId = E.Id,
            //               DepId = D.Id,
            //               EmpName = E.Name,
            //               DeptName = D.DeptName
            //           };


            //Tracking vs NoTracking

            using FirstDbContext context = new FirstDbContext();
            var result = context.Employees.FirstOrDefault(E => E.Id == 10);


        }
    }
}
