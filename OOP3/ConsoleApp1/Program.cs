using ConsoleApp1.Intefaces;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //b) To define a blueprint for a class
            #endregion

            #region Q2
            //a) private
            #endregion

            #region Q3
            //b) No 
            #endregion

            #region Q4
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5
            //d) Implements
            #endregion

            #region Q6
            //a)Yes
            #endregion

            #region Q7
            //b) No, all members are implicitly public
            #endregion

            #region Q8
            //b) To provide a clear separation between interface and class members
            #endregion

            #region Q9
            //b) No, interfaces cannot have constructors

            #endregion

            #region Q10
            //c) By separating interface names with commas



            #endregion

            //Part2
            #region Q1
            //ICircle circle = new Circle { Radius = 5 };
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle { Length = 2, Width = 5 };
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q2
            //IAuthenticationService authServie = new BasicAuthenticationService();

            //bool isAuthenticated = authServie.AuthenticateUser("Nada Eissa", "1245");
            //Console.WriteLine($"isAuthenticated : {isAuthenticated}");

            //bool isAuthorized = authServie.AuthorizeUser("Nada Eissa", "Admin");
            //Console.WriteLine($"isAuthorized : {isAuthorized}");
            #endregion

            #region Q3
            INotificationService emaailServie = new EmailNotificationService();
            emaailServie.SendNotification("Nada@gh.com", "Welcome!");

            INotificationService smsServie = new SmsNotificationService();
            smsServie.SendNotification("1214454", "Hello");

            INotificationService pushService = new PushNotificationService();
            pushService.SendNotification("Nada", "Welcome!!");
            #endregion

















        }
    }
}
