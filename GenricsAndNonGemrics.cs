using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Access
{
    class GenricsAndNonGemrics
    {
        //       Non-generic                  Generic
        //ArrayLis------------->          List
        //HashTable  ------------->        Dictionary
        //SortedList   ------------->      SortedList
        //Stack           ------------->    Stack
        //Queue         ------------->        Queue


    }
  public  class NonGenrics
    {
        public void ArrayList()
        {
            ArrayList al = new ArrayList();
            string str = "kiran teja jallepalli";
            int x = 7;
            DateTime d = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(7);
            al.Add(d);

            foreach (object o in al)
            {
                Console.Write(o);
            }

        }

        public void HadTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry d in ht)
            {
                Console.Write(d.Key + " " + d.Value);
            }

        }

        public void SortedList()
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry d in sl)
            {
                Console.Write(d.Key + " " + d.Value);

            }
        }

        public void Stack()
        {
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");
            foreach (object o in stk)
            {
                Console.Write(o + "<br>");
            }
        }

        public void Queue()
        {
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (object o in q)
            {
                Console.Write(o + "<br>");
            }
        }



    }


    class Genrics
    {
        public void GenricList()
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            foreach (int i in lst)
            {
                Console.Write(i + "<br>");
            }
        }

        public void Dictonary()
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.Write(kvp.Key + " " + kvp.Value);
                
            }
        }

        public void SortedList()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.Write(kvp.Key + " " + kvp.Value);
               
            }
        }


        public void Stack()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string s in stk)
            {
                Console.Write(s + "<br>");
            }
        }
        public void Queue()
        {
            Queue<string> q = new Queue<string>();

            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            {
                Console.Write(s + "<br>");
            }
        }


    }

}
