namespace C__ADV3
{

    #region Delegate
    //Strp01:Create for delegate

    public delegate int StringFuncDelegate(string s);
    //New Delegate (Class) , REF(point) can refer to function of more(pointer of Functions)
    //these must have the same signature of delegate:int(string)
    //Regardeless the Name of Function or the name of Paramater , access modifier
    #endregion


    #region EX
    //public delegate List<int> stringDelegateFunc(int i);
    //public static List<int> FindNumbers(List<int> list , stringDelegateFunc refe)
    //{
    //    List<int> Result = new List<int>();
    //    if(list is not null)
    //    {
    //        for(int i = 0; i < list.Count; i++)
    //        {
    //            if (refe.Invoke(list[i])
    //                Result.Add(list[i]);
    //        }
    //    }

    //}
    #endregion


    internal class Program
    {

       
        static void Main(string[] args)
        {

            #region Delegate Overview
            //Delegate : C# Feature

            //C# Pure OOP

            //Functional Programming
            //Event-Driven Programming

            //Java Pure OOP

            //DP
            #endregion

            #region Delegate EXs
            //step02: Use delegate 
            //   StringFuncDelegate  X = StringFunctions.GetCountOfUpperCaseChar; //syntaxSugar

            //    //StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar);


            //   X += StringFunctions.GetCountOfLowerCaseChar;


            //    //int count = X.Invoke("Hi Nada Eissa");
            //    int count = X("Hello WorLD"); //SyntaxSugar


            //    Console.WriteLine(count);
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //List<string> names = new List<string>() { "Mada", "Nada" };
            #endregion


            #region Built-in Delegate predicate , Func , Action
            //built in Delegate

            //predicate , Func , Action

            //Predicate<int> predicate = ConditionsFunctions.CheckEven;
            //predicate(1);

            ////Func
            //Func<bool> func = Fun01;
            //Func<int, bool> func1 = ConditionsFunctions.CheckEven;
            //Func<int, int, bool> fun2 = SortingFunctions.compare;

            ////Action

            //Action<int> action = Print;
            #endregion





        }

    }
    }
