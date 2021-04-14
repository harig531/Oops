using System;
using System.Linq;
using System.Threading.Tasks;
using Oops;
public delegate void HelloDelitgateMessage(string Name);
public delegate void MulticastDelegate(int x, int y);
namespace Access
{
    class Program
    {
        //static String location;
        //static DateTime time;
        static void Main(string[] args)
        {

          

            a a = new a();
            a.print();
            a ab = new b();
            ab.print();
            a ac = new c();
            ac.print();
            Parallel.Invoke(

                () => EmpSingleTone(),
                 () => StudentSingleTone()
                );
            string name = "hari";
            Console.WriteLine(name.FirstCharLetterChange());

            PrintNumberRecursive(10);
            Console.WriteLine(AddNumberUsingRecursive(102));

            MulticastDelegate md = new MulticastDelegate(empsum);
            md(10, 20);

            VaribleStaticReadonly varibleStaticReadonly = new VaribleStaticReadonly();
            Console.WriteLine(varibleStaticReadonly);
            //EmpSingleTone();
            //StudentSingleTone();

           
        }
        private static void empsum(int x,int y)
        {
            SingleToneClass singleEmployee = SingleToneClass.getobject;
            singleEmployee.Printmessage("Hari Employee");
        }







        private static void EmpSingleTone()
        {
            SingleToneClass singleEmployee = SingleToneClass.getobject;
            singleEmployee.Printmessage("Hari Employee");
        }
        private static void StudentSingleTone()
        {
            SingleToneClass singleStudent = SingleToneClass.getobject;
            singleStudent.Printmessage("Hari Student");

        }


        public static int AddNumberUsingRecursive(int val)
        {
            if (val != 0)
                return (val % 10 + AddNumberUsingRecursive(val / 10));
            else
                return 0;
        }




        public static void helloMessage(string Message)
        {
            Console.WriteLine(Message);
        }

        internal static void ReverseString(string str)
        {

            char[] charr = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {

                charr[i] = str[j];
                charr[j] = str[i];
            }
            Console.WriteLine(new string(charr));
        }

        internal static void PrintNumberRecursive(int number)
        {
            if (number < 0)
                return;
            PrintNumberRecursive(number - 1);
            Console.WriteLine(number);
        }


        internal static void Pilindram(string str)
        {
            bool flag = true;
            // char[] charr = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
            }
            Console.WriteLine(flag == true ? "string is pillindram" : "string is not pillindram");
        }

        internal static void reverseorder(string str)
        {
            string[] arr = str.Split(" ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");

            }

        }

        internal static void reverseeachorder(string str)
        {
            string[] arr = str.Split(" ");
            string strinput = string.Empty;
            char[] chararr = null;

            for (int k = 0; k < arr.Length; k++)
            {
                strinput = arr[k];
                chararr = strinput.ToCharArray();
                for (int i = 0, j = strinput.Length - 1; i < j; i++, j--)
                {
                    chararr[i] = strinput[j];
                    chararr[j] = strinput[i];
                }
                Console.Write(new string(chararr) + " ");
            }
        }

        internal static void eachcharcountorder(string str)
        {
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int cal = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }

        internal static void removeduplicate(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                    result += str[i];

            }
            Console.WriteLine(result);
        }

        internal static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }

        //With recursion
        //With Factorial
        internal static double Factroial(int num)
        {
            if (num == 0)
                return 1;
            return num * Factroial(num - 1);
        }
        internal static double FactroialWithOut(int num)
        {
            if (num == 0)
                return 1;
            double fact = 1;
            for (int i = num; i >= 1; i--)
            {
                fact = fact * i;

            }


            return num * Factroial(num - 1);
        }


        internal static void FindSecondLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            Console.WriteLine(max2);
        }



    }




    public class MyClass
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("You are in Add() Method");
            Console.WriteLine("{0} + {1} = {2}\n", x, y, x + y);
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("You are in Multiply() Method");
            Console.WriteLine("{0} X {1} = {2}", x, y, x * y);
        }
    }


    class Hacker
    {


        Program program = new Program();

        public static void PrintData(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i >= 3)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else if (i % 3 == 0 && i % 5 != 0)
                        Console.WriteLine("Fizz");
                    else if (i % 3 != 0 && i % 5 == 0)
                        Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(i);
            }
        }


        public static void decodeStrings(int numberOfRows, string encodedString)
        {

            if (numberOfRows == 1)
            {
                Console.Write(encodedString);
                return;
            }

            char[] str1 = encodedString.ToCharArray();
            int len = encodedString.Length;
            string[] arr = new string[numberOfRows];
            int row = 0, rest = 0, maxvaluefor = str1.Length / numberOfRows;
            bool loopbreaks = false; bool isMainbreak = false;
            for (int i = 0; i < len; ++i)
            {

                arr[row] += (str1[i]);
                if (rest == (maxvaluefor - 1))
                {
                    row++;
                    rest = 0;
                }
                else
                    rest++;
            }
            for (int i = 0; i < arr[0].Length; ++i)
            {
                int icount = i;
                for (int j = 0; j < numberOfRows; ++j)
                {
                    if (Convert.ToString(arr[j][icount]) == "_")
                    {
                        Console.Write(" ");

                        icount++;
                        continue;
                    }
                    Console.Write(arr[j][icount]);
                    if (loopbreaks == true)
                    {
                        isMainbreak = true;
                        break;
                    }
                    if (numberOfRows == j + 1 && icount + 1 == arr[j].Length)
                    {
                        loopbreaks = true;
                    }
                    icount++;

                }
                if (isMainbreak)
                    break;

            }
        }

        public static string decodeString(int numberOfRows, string encodedString)
        {


            if (numberOfRows == 1)
            {

                return encodedString;
            }

            char[] str1 = encodedString.ToCharArray();
            int len = encodedString.Length; string returnvalue = string.Empty;
            string[] arr = new string[numberOfRows];
            int row = 0, rest = 0, maxvaluefor = str1.Length / numberOfRows;
            bool loopbreaks = false; bool isMainbreak = false;
            for (int i = 0; i < len; ++i)
            {

                arr[row] += (str1[i]);
                if (rest == (maxvaluefor - 1))
                {
                    row++;
                    rest = 0;
                }
                else
                    rest++;
            }
            for (int i = 0; i < arr[0].Length; ++i)
            {
                int icount = i;
                for (int j = 0; j < numberOfRows; ++j)
                {
                    if (Convert.ToString(arr[j][icount]) == "_")
                    {
                        returnvalue += " ";

                        icount++;

                        if (loopbreaks == true)
                        {
                            isMainbreak = true;
                            break;
                        }

                        continue;
                    }
                    returnvalue += arr[j][icount];
                    if (loopbreaks == true)
                    {
                        isMainbreak = true;
                        break;
                    }
                    if (numberOfRows == j + 1 && icount + 1 == arr[j].Length)
                    {
                        loopbreaks = true;
                    }
                    icount++;

                }
                if (isMainbreak)
                    break;

            }
            return returnvalue;
        }



    }




    class Inher : Inher3
    {



        public void first2()
        {
            throw new NotImplementedException();
        }
    }



    public abstract class Abstractmethod
    {
        public abstract void Sum();

        public int sum()
        {
            return 20;
        }
    }

    class inhe : Abstractmethod
    {


        public override void Sum()
        {
            throw new NotImplementedException();
        }
    }
    public class second
    {
        int _a, _b;
        public second(int a, int b)
        {
            this._a = a;
            this._b = b;

        }
        public void HelloMessage()
        {
            Console.WriteLine("Print : {0}", _a + _b);

        }
    }

    interface Inher3
    {
        void first2();
    }


    public abstract class staticctor
    {


        //static staticctor()
        //{
        //    Console.WriteLine("default");
        //}

        public static void decodeStrings22()
        {
            Console.WriteLine("haaa");

        }
    }

    class staticctor1
    {

    }

class a
    {
        public virtual void print()
        {
            Console.WriteLine("clas a");
        }
    }

class b: a
    {
        public override void print()
        {
            Console.WriteLine("clas b");
        }
    }

class c : b
    {
        public new void print()
        {
            Console.WriteLine("clas c");
        }
    }
}
