using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV3
{
    internal class SortingAlgo
    {
        public delegate bool SortingFunCDelegate(int A, int B);

        public static void BubbleSort(int[] Arr, SortingFunCDelegate reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }


        //public static void BubbleSortAsending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for(int i = 0; i<Arr.Length; i++)
        //        {
        //            for(int j = 0; j < Arr.Length; j++)
        //            {
        //                if (SortingFunctions.CompareGtr( Arr[j] , Arr[j +1]))
        //                    SWAP(ref Arr[j], ref Arr[j+1]); 
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSortDesending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length; j++)
        //            {
        //                if (Arr[j] < Arr[i + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        private static void SWAP(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;

        }
    }
}
