using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
   public sealed class SingleToneClass
    {
        private static int iNoOfObj = 0;
      
        private static readonly Lazy<SingleToneClass> _instanceobj =
            new Lazy<SingleToneClass>(() => new SingleToneClass());
        public static SingleToneClass getobject
        {
            get
            {
                return _instanceobj.Value;
            }
        }

        //method-1
        //private static readonly SingleToneClass _instanceObj = new SingleToneClass();
        //public static SingleToneClass GetObject
        //{
        //    get
        //    {
        //        return _instanceObj;
        //    }
        //}

        //method-2
        //private static SingleToneClass _instanceObj = null;
        //private static readonly object obj = new object();
        //public static SingleToneClass GetObject
        //{
        //    get
        //    {
        //        if (_instanceObj == null)
        //        {
        //            lock (obj)
        //            {
        //                if (_instanceObj == null)
        //                    _instanceObj = new SingleToneClass();
        //            }
        //        }
        //        return _instanceObj;
        //    }
        //}

        private SingleToneClass()
        {
            iNoOfObj++;
            Console.WriteLine("How many instance created"  + iNoOfObj);
        }

        public void Printmessage(string Meassage)
        {
            Console.WriteLine("Print The messages" + Meassage);
        }

    }

   
}
