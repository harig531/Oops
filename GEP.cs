using System;
using System.Collections.Generic;
using System.Text;

namespace Access
{
    class GEP
    {

        public static int getValue(int a)
        {
            try
            {
                a = 10;
                throw new Exception();
            }
            catch
            {
                a = 20;
                return a;
            }
            finally
            {
                a = 30;
             //   return a;
            }


        }
    }
}
