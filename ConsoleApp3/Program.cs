namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 string Concatentaion
            //2 String Format
            int X = 4, Y = 3;
            String Message = String.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);
            Console.WriteLine(Message);
        }   
    }
}
