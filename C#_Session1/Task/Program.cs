using System.Collections;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Optimized Bubble Sort

            //int[] arr = { 5, 3, 8, 4, 2 };
            // Sorting.OptimizedBubbleSort(arr);
            //Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
            #endregion

            #region Range

            //Range<int> range = new Range<int>(11, 15);
            //Console.WriteLine("Is 10 in range: " + range.IsInRange(10));
            //Console.WriteLine("Length of range: " + range.Length());
            #endregion

            #region ReverseArray
            //ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            // RevArr.ReverseArrayList(list);
            //Console.WriteLine("Reversed ArrayList: " + string.Join(", ", list.ToArray()));
            #endregion

            #region EvenNumbers
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            //List<int> evenNumbers = EvenNum.GetEvenNumbers(numbers);
            //Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
            #endregion

            #region FixedSizeList
            //FixedSizeList<string> fixedList = new FixedSizeList<string>(2);
            //fixedList.Add("Hello");
            //fixedList.Add("Nada");
            //Console.WriteLine("Element at index 1: " + fixedList.Get(1));
            #endregion

            #region First Non-Repeated Character
            //string input = "Nada";
            //int index = FNRC.FirstNonRepeatedCharacter(input);
            //Console.WriteLine("Index of first non-repeated character: " + index);
            #endregion
        }
    }
}
