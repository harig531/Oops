using System;
using System.Linq;

namespace Oops
{
    public delegate void HelloMeassgeDeligate(string message);
    class Program
    {
        static void Main(string[] args)
        {

            string[] ara = new string[] { "Guntu", "Hari", "Guntuuuuuuuuu" };
            string[] vs = (from a in ara where a.Length > 2 select a).ToArray();


            //int[] s = { 1, 2, 3, 3, 4 };
            //int[] q = s.Distinct().ToArray();
            //foreach (int value in q)
            //{
            //    Console.Write(value + " ");
            //}

            //  int[] marks = new int[] { 99, 98, 92, 97, 95 };
            //  FindSecondLargeInArray(marks);
            //removeduplicate(str);
            // eachcharcountorder(str);
            //reverseeachorder(str);
            // Pilindram(str);
            // reverseorder(str);
            //    ReverseString(str);
            //Console.WriteLine(Math.Round(30.5));
            //Console.WriteLine(Math.Round(9.5) +"-" + Math.Round(19.5) + "-" + Math.Round(21.5));
            //Console.ReadKey();
            //string[] ara = new string[] { "Guntu", "Hari", "Guntuuuuuuuuu" };
            //string[] vs = (from a in ara where a.Length >= 5 select a).ToArray();

            //for (int i = 0; i < vs.Length; i++)
            //{
            //    Console.WriteLine(vs[i]);
            //}
            //int[] array = new int[7] { 1, 3, 5, 2, 8, 6, 4 };
            //var topThree = (from i in array
            //                orderby i descending
            //                select i).Take(3);

            //foreach (var x in topThree)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] topThree1 = array.OrderByDescending(i => i)
            //          .Take(3)
            //          .ToArray();

            //foreach (var x in topThree1)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.ReadKey();
            ////string name = "sandeep";
            ////              string myName = name;
            ////Console.WriteLine("== operator result is {0}", name == myName);
            ////Console.WriteLine("Equals method result is {0}", name.Equals(myName));
            ////Console.ReadKey();


            ////HelloDelitgateMessage delitgateMessage = new HelloDelitgateMessage(helloMessage);
            ////delitgateMessage("Hari");

            ////MulticastDelegate multicast = new MulticastDelegate(MyClass.Add);
            ////multicast += new MulticastDelegate(MyClass.Multiply);
            ////multicast(10, 20);

            //////second second = new second(10, 20);
            //////second.HelloMessage();

            //////staticctor st = new staticctor();
            //////st = new staticctor();
            ////// Hacker.PrintData(15);

            ////int numberOfRows = Convert.ToInt32(Console.ReadLine().Trim());

            ////string encodedString = Console.ReadLine();

            ////Console.WriteLine(Hacker.decodeString(numberOfRows,encodedString));




            // Hacker hacker = new Hacker();

        }
        //public static void HelloMessage(string messag)
        //{
        //    HelloMeassgeDeligate helloMeassgeDeligate = new HelloMeassgeDeligate(HelloMessage);
        //    helloMeassgeDeligate("deligate class");
        //    Console.WriteLine("Message Form {0}",messag);
        //}




    }



    interface a
    {
        void abc();
    }

    interface b
    {
         void abc();
    }


    class basicpro : a, b
    {
         void a.abc()
        {
            Console.WriteLine("interfaceaA");
            
        }
         void b.abc()
        {
            Console.WriteLine("interfaceab");
        }

        
    }
    public class abc
    {
      public  int i = 10;

        public void HelloMessage(string messag)
        {
            Console.WriteLine("Message Form {0}", messag);
        }
    }
}
