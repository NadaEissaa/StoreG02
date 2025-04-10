namespace Assignment
{
    internal class Program
    {
        #region functionQ1

        public static void FirstQuestion()
        {
            Console.WriteLine("Q1 :");
            int[] array = { 11, 5, 3 };
            int[] quieries = { 1, 5, 13 };
            foreach(int x in quieries)
            {
                int count = 0;
                for(int i = 0; i <array.Length; i++)
                {
                    if(array[i] > x){
                        count++;
                    }

                }
                Console.WriteLine(count);
            }
            Console.WriteLine();
        }
        #endregion

        #region FunctionQ2
        public static void SecondQuestion()
        {
            Console.WriteLine("Q2:");
            int[] array = { 1, 2, 3, 2, 1 };
            //int[] array = { 1, 2, 3, 7, 1 };
            bool isPalindrome = true;
            for(int i = 0; i < array.Length /2; i++)
            {
                if (array[i] != array[array.Length-1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome ? "YES" : "NO");
            Console.WriteLine();
        }
        #endregion

        #region FunctionQ3
        public static void ThirdQuestion()
        {
            Console.WriteLine("Q3:");
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            Stack<int> stack = new Stack<int>();

            while(queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine(string.Join(" , ", queue));
            Console.WriteLine();

        }
        #endregion

        #region FunctionQ4
        public static void FouthQuestin()
        {
            Console.WriteLine("Q4:");
            string input = "[(]{()}";
            Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");
            Console.WriteLine();

            bool IsBalanced(string str)
            {
                Stack<char> stack = new Stack<char>();
                foreach (char ch in str)
                {
                    if (ch == '(' || ch == '{' || ch == '[')
                        stack.Push(ch);
                    else
                    {
                        if (stack.Count == 0)
                            return false;
                        char top = stack.Pop();
                        if ((ch == ')' && top != '(') ||
                            (ch == '}' && top != '{') ||
                            (ch == ']' && top != '['))
                            return false;
                    }
                }
                return stack.Count == 0;
            }
        }
        #endregion

        #region FuntionQ5
        public static void FifthQuestin()
        {
            Console.WriteLine("Q5:");
            int[] array = { 7, 4, 4, 5, 2, 7, 11, 9 };
            List<int> unique = new List<int>();
            foreach(int num in array)
            {
                if (!unique.Contains(num))
                {
                    unique.Add(num);
                }
            }
            Console.WriteLine(string.Join(" , ", unique));
            Console.WriteLine();

        }
        #endregion

        #region FunctionQ6
        public static void SixthQuestin()
        {
            Console.WriteLine("Q6:");
            List<int> list = new List<int> { 1, 2, 12, 5, 8, 10, 11,3 };


            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 != 0)
                    list.RemoveAt(i);
            }
            Console.WriteLine(string.Join("  , ", list));
            Console.WriteLine();
        }
        #endregion


        #region FunctionQ7
        public static void SeventhQuestin()
        {
            Console.WriteLine("Q7:");
            Queue<object> queue = new Queue<object>();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);

            while (queue.Count> 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine();

        }
        #endregion


        #region FunctionQ8
        public static void EightQuestion()
        {
            Console.WriteLine("Q8:");
            Stack<int> stack = new Stack<int>(new[] { 1, 5, 11, 15, 100, 250, 80, 7 });
            Console.WriteLine("Enter the target number :");
            Console.WriteLine();
            int target = int.Parse(Console.ReadLine());
            int count = 0;
            bool found = false;

            foreach(int i in stack)
            {
                count++;
                if(i == target)
                {
                    found = true;
                    Console.WriteLine($"Target was fount found successfully and the count = {count}");
                    break;
                }
            
            }
            if (!found)
            {
                Console.WriteLine("Target was not found :(");
                Console.WriteLine();
            }

        }
        #endregion


        #region FunctionQ9
        public static void NinthQuestion()
        {
            Console.WriteLine("Q9:");
            int[] array = { 1, 2, 3, 4, 4 };
            int[] array2 = { 10, 4, 4, 2 };
            List<int> list = new List<int>();

            foreach(int num in array)
            {
                for(int j = 0; j < array2.Length; j++)
                {
                    if(num == array2[j])
                    {
                        list.Add(num);
                        array2[j] = int.MinValue;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" , " , list));
            Console.WriteLine();

        }
        #endregion


        #region FunctionQ10
        public static void TenthQuestion()
        {
            Console.WriteLine("Q10:");

       
            Console.Write("Enter the list of integers (comma-separated): ");
            string input = Console.ReadLine();
            List<int> list = input.Split(',').Select(int.Parse).ToList();

        
            Console.Write("Enter the target sum: ");
            int target = int.Parse(Console.ReadLine());

       
            for (int i = 0; i < list.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < list.Count; j++)
                {
                    sum += list[j];
                    if (sum == target)
                    {
                        Console.WriteLine($"Sub-list: {string.Join(", ", list.GetRange(i, j - i + 1))}");
                        return;
                    }
                }
            }
            Console.WriteLine("No sub-list found");
            Console.WriteLine();
        }
        #endregion


        #region FunctionQ11
        public static void EleventhQuestion()
        {
            Console.WriteLine("Task 11:");
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            int k = 2;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());

            for (int i = 0; i < queue.Count - k; i++)
                queue.Enqueue(queue.Dequeue());

            Console.WriteLine(string.Join(", ", queue));
            Console.WriteLine();
        }
        #endregion
        static void Main(string[] args)
        {
            FirstQuestion();
            SecondQuestion();
            ThirdQuestion();
            FouthQuestin();
            FifthQuestin();
            SixthQuestin();
            SeventhQuestin();
            EightQuestion();
            NinthQuestion();
            TenthQuestion();
            EleventhQuestion();


        }

    }
}
