using C__ADV4.FIFA;
using C__ADV4.YouTube;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading.Channels;

namespace C__ADV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Event EX01
            //Ball ball = new Ball() { Id = 1 } ;

            //Console.WriteLine(ball);
            //Player p01 = new Player() { Name = "Messi", TeamName = "Miami" };

            //Player p02 = new Player() { Name = "ADFd", TeamName = "Miami" };


            //Player p03 = new Player() { Name = "Mesi", TeamName = "DDD" };

            //Player p04 = new Player() { Name = "AFd", TeamName = "WW" };

            //Referee R01 = new Referee() { Name = "Ahmed nor" };

            //ball.Players.Add(p01);
            //ball.Players.Add(p02);
            //ball.Players.Add(p03);
            //ball.Players.Add(p04);
            //ball.Referee.Add(R01);

            //ball.location = new Locationcs() { X = 2, Y = 1, Z = 1 };
            //Console.WriteLine(ball);
            #endregion


            #region Event EX02
            //Channel channel = new Channel() { Title = "ADB" };
            //channel.AddVideo(new Vides() { Title = "Title01", AssemblyDescriptionAttribute = "Desc01"});

            //Subscriber S01 = new Subscriber() { Name = "A" };
            //Subscriber S02 = new Subscriber() { Name = "dA" };
            //Subscriber S03 = new Subscriber() { Name = "dA" };
            //channel.AddVideo(new Vides() { Title = "Title01", AssemblyDescriptionAttribute = "Desc02" });

            //channel.Uploaded += S01.Notify;

            //channel.Uploaded += S02.Notify;

            //channel.Uploaded += S03.Notify;
            //channel.AddVideo(new Vides() { Title = "Title01", AssemblyDescriptionAttribute = "Desc03" });


            #endregion


            #region Non-Generic hash tables :HashTable
            ////Collections: Built in DS on C#


            ////Hash Tables :
            //// Key , Value 
            //// Non-Generic hash tables
            ////Generic hash tables


            //// Non-Generic hash tables :HashTable

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("Ahmed", 455);
            //hashtable.Add("omar", 45545);
            //hashtable.Add("Nada", 45445);



            //foreach(DictionaryEntry item in hashtable.Values)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Generic hash tables : Dictionary

            //Generic hash tables : Dictionary


            //Dictionary<string, long> pairs = new Dictionary<string, long>();

            //pairs.Add("Ahmed", 4545454545454);

            //pairs.Add("Nada", 4545454545454);



            //foreach(KeyValuePair<string,long> pair in pairs)
            //{
            //    Console.WriteLine(pair);
            //}


            #endregion


            #region Generic hash tables :HashSet

            // HashSet

            // hashtables

            //HashSet<string> set = new HashSet<string>();
            //set.Add("A");
            //set.Add("Nada");

            //foreach(var item in set){


            //    Console.WriteLine(item);

            //}
            #endregion


        }


    }
}
