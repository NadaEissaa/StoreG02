using System.Collections;

namespace C_ADV2
{
    internal class Program

    {
        #region SumArrayList
        //public static void sumArrayList(ArrayList arraylist)
        //{
        //    int sum = 0;
        //    if (List is not null)
        //    {
        //        for(int i = 0; i < List.Count; i++)
        //        {
        //            sum+= (int)list[i];
        //        }
        //    }
        //}
        #endregion

        #region printLInkedList
        //public static void printLInkedList(LinkedList<int> linkedlist)
        //{
        //    Console.WriteLine();
        //    foreach(int item in linkedlist)
        //    {
        //        Console.WriteLine($"<- {item} ->");
        //    }
        //} xx
        #endregion

        static void Main(string[] args)
        {
            #region What is Collections?
            //Collections : Built-in DS in C#
            // Array :Container 


            //Collections in C#
            // Lists
            // Hash tables

            //Generic - Non Generic
            //Lists:
            //Non Generic Lists : ArrayList - Stack - Queue
            //Generic Lists : List , linkedList , Stack , Queue

            //HashTables
            //Non-Generics HashTables :HashTable
            //Generics HashTables :Dictionary - SortedDictionary
            #endregion

            #region Non-Generics Lists : ArrayList

            //Lists
            //Non-Generics Lists : ArrayList

            //ArrayList like array
            //Array Based
            //Index

            //Array Indexed Collection: Fixed Size
            //ArrayList  Indexed Collection: Dynamic Size

            //int[] numbers = { 9, 5, 7, 5, 6 };
            //Console.WriteLine(numbers);
            //numbers[1] = 12;

            //Console.WriteLine(numbers);

            //ArrayList list = new ArrayList( new int[] { 1 , 4 , 5 , 11 , 4});
            //Console.WriteLine($"Count : {list.Count} , capacity {list.Capacity}");
            //list.Add(2);
            //Console.WriteLine($"Count : {list.Count} , capacity {list.Capacity}");

            //Employess E01 = new Employess() { Id = 1, Name = "Nada ", Salary = 45000, Age = 21 };

            //Employess E02 = new Employess() { Id = 2, Name = "Ahmed ", Salary = 45000, Age = 21 };

            //Employess E03 = new Employess() { Id = 3, Name = "Mohamed ", Salary = 45000, Age = 21 };


            //ArrayList list = new ArrayList();
            //list.AddRange(new Employess[] { E01, E02, E03 });

            //foreach(Employess item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Problem with Non Generic lists [ArrayList]
            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(3);
            //list.Add(7);
            //list.Add(9);
            //list.Add("Hello World");

            //int Sum = SumArrayList(list);
            //Console.WriteLine(Sum);
            #endregion

            #region Generic Lists : Lists
            //Generic Lists : Lists
            //Lists : version Generic of Arraylist

            //list like arraylist like array : Generic - Dynamic size
            List<int> list = new List<int>();

            //list.EnsureCapacity(10);

            //Console.WriteLine($"count : {list.Count} , capacity : { list.Capacity}");
            //list.EnsureCapacity(10);
            //Console.WriteLine($"count : {list.Count} , capacity : {list.Capacity}");

            //List<int> result = list.GetRange(0, 2);
            #endregion


            #region Generic Lists : Linked list
            //Generic Lists : Linked list

            //LinkedList<int> linkedlist = new LinkedList<int>();

            //linkedlist.AddFirst(7);
            //linkedlist.AddFirst(9);

            //printLInkedList(linkedlist);

            //linkedlist.AddLast(5);
            //linkedlist.AddLast(11);

            //linkedlist.Clear();

            //Console.WriteLine(linkedlist.First.Next.Value);
            #endregion


            #region Generic Lists: Queue
            //Generic Lists: Queue

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);


            //queue.Dequeue();
            #endregion






        }
    }
}
