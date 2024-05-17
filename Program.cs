namespace Prog120_S24_L10_MethodsPart2
{
    internal class Program
    {
        // If you declare a variable at the class scope
        // it must have static before it
        static int age = 20;

        static void Main(string[] args)
        {
            // Value
            int num1;
            bool bool1 = true;
            double double1 = 5.5;

            OutKeyword(out num1);

            Console.WriteLine(num1);


        } // void

        #region Question1


        #endregion

        // out key
        // the out keyword insists that the value MUST be changed inside of the method
        public static void OutKeyword(out int number)
        {
            number = 7;
        }


        // ref
        // ref keyword
        // you place the ref keyword in front of a parameter to indicate you are passing by reference
        public static void PassingAValueByRef(ref int number)
        {
            Console.WriteLine($"Before Being Assigned : {number}");
            number = 10;
            Console.WriteLine($"After Being Assigned : {number}");
        }

        public static void PassingByRefExample()
        {
            int num1 = 5;
            // When passing in a ref variable
            // you must put the ref keyword before the arugment
            PassingAValueByRef(ref num1);

            Console.WriteLine($"Value after the method: {num1}");
        }

        // Passing by reference
        public static void ChangeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }

        public static void ChangingTheArrayExample()
        {
            //// By Reference
            int[] array1 = new int[5];
            ChangeArray(array1);
            // foreach
            // foreach ( type name in collection ) { code to loop }
            foreach (int number in array1)
            {
                Console.WriteLine(number);
            }
        }

        // Passing by values
        public static void ChangeValue(int number)
        {
            Console.WriteLine($"Before Being Assigned : {number}");
            number = 10;
            Console.WriteLine($"After Being Assigned : {number}");
        }

        #region ChangeValue - Global

        // Changed a value in a class scope
        public static void ChangeValue()
        {
            Console.WriteLine($"Current Age:{age}");
            age = 30;
            Console.WriteLine($"After Change:{age}");
        }

        public static void ChangeValueExampleGlobal()
        {

            ChangeValue();

            Console.WriteLine("Outside of method " + age);
        }
        #endregion




        // in(?)

    } // class

} // namespace
