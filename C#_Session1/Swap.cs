using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Session1
{
    internal class Swap
    {

        #region non_Generic_Swap
        //public static void SWAP ( ref int X , ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}

        //public static void SWAP( ref double X, ref double Y)
        //{
        //    double temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion

        #region Generic Swap
        public static void SWAP<T>(ref T X, ref T Y)
        {

            T temp = X;
            X = Y;
            Y = temp;
        }
        //public static void Print(T data)
        //{
        //    Console.WriteLine(data);
        //}
        #endregion

        #region Non Generic
        //Non Generic
        //public static int LinearSearch(int[] Arr, int Value)
        //{
        //    if(Arr?.Length > 0)
        //    {
        //        for(int i=0; i <Arr.Length; i++)
        //        {
        //            if (Arr[i] == Value)
        //                return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region Generic Linear Search
        //Generic Linear Search
        //        public static int LinearSearch<T>(T[] Arr, T Value) 
        //{
        //    if(Arr?.Length > 0)
        //    {
        //        for(int i=0; i <Arr.Length; i++)
        //        {
        //            if (Arr[i].Equals(Value))
        //                return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        public static void BubbleSort<T>(T[] Arr) where T :IComparable
        {
            if (Arr?.Length > 0)
            {
                for(int i = 0; i < Arr.Length; i++)
                {
                    for(int j = 0; j < Arr.Length -1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j+1]) >0)
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

    }
}
