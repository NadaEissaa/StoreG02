namespace ConsoleAppSession2Demp
{
    internal class Program
    {
 
     
        //Entry Point///
        static void  Main()
        {
            #region MyRegion
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            #endregion

            #region Variables
            // Variable Declaretion
            //Datatype VariableName
            //int Number;
            // AllocateUnInitialized 4 Bytes at Memory

            //Console.WriteLine(Number); //Invalid
            //int Number01 = 12, Number02 = 3, Number03 = 4;

            //Number = 12;
            //Console.WriteLine(Number);

            //Variable
            //1. Name     : Number
            //2. Datatype :int
            //3. Value    :12
            //4. Size     :4bytes
            //5. Address 
            #endregion

            #region Datatype (Value Type) : STACK
            //Datatype (Value Type) : STACK
            //int Number;
            //Allocate UnInitialized 4 Bytes At Stack
            // int : c# Keyword

            //Number = 5;
            //Console.WriteLine(Number);

            //Int32 Number = 12;
            //Console.WriteLine(Number); 
            #endregion

            #region Datatype (Refernce Type) : Heap
            //Datatype (Refernce Type) : Heap
            //point P01;
            //Declare Refrence (Pointer) From Type 'point'
            //P01 : Can Refer To Object From Type 'Point'
            //P01 : Refer To Null

            //8 Bytes Will Be Allocated At Stack For Refrence 'P01'
            //0 Bytes Will Be Allocated At Heap

            //P01 = new point();
            //New
            //1. Allocate The Number Of Required Bytes For Object at HEAP (8 Bytes + CLR Overhead)
            //2. Initialized The Allocated Bytes At Heap With The Defualt Value Of The Datatype
            //3. CallUser-Defined Constructor Exists
            //4. Assign The Object To Referenece 'P01'

            //Console.WriteLine(P01.x); //0
            //Console.WriteLine(P01.Y); //0
            //Console.WriteLine(P01); //C_Basic01G02.Piont
            //Point P02 = new point(); 
            #endregion

            #region Casting
            #region Object
            //object 01;
            //Declare for reference (point) from type 'object'
            //Point P01 = new Point();
            //Console.WriteLine(P01.ToString());
            //Console.WriteLine(P01);
            //Console.WriteLine(P01.GetHashCode());

            //P01.GetType();
            //P01.GetHashCode(); 
            #endregion

            //casting : convert from any datatype to any datatype
            //1. implicit casting
            //int x = 5;
            //double y = /(double)/ x; //implicity casting (safe casting)
            //Console.WriteLine(y);

            //2. explicit casting
            //double x = 1.4;
            //int y = (int)x; // explicit casting (unsafe casting)
            //may cause problem

            //Console.WriteLine(y);

            //long x = 11111111111111111;
            //int y = (int)x; //explicit casting (unsafe casting)
            //Console.WriteLine(y);
            //Console.WriteLine(uint.MaxValue); 
            #endregion

            #region casting
            //parse :function
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine()); // may throw exception
            //Console.WriteLine("age : " + age);

            //convert : class
            //int age = Convert.ToInt32(Console.ReadLine()); // may throw exception
            //Console.WriteLine("age : " + age);

            //tryparse : function
            //int age;
            //bool flag = int.TryParse(Console.ReadLine(), out age); // may throw exception
            //Console.WriteLine("age : " + age);
            //Console.WriteLine("flag : " + flag); 
            #endregion
            

            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            //Console.WriteLine("You entered: " + input);


        }

    }
    }
