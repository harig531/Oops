using System;
using System.Collections.Generic;
using System.Text;

namespace Access
{
    class VaribleStaticReadonly
    {
        const string constValue="Hari";
        readonly string readonlyvalue="hari";
        static readonly string staticReaonlyvalue="haro";


        static VaribleStaticReadonly()
        {
            staticReaonlyvalue = "hari statuc";
            staticReaonlyvalue += "hari 2 statuc";
            Console.WriteLine(staticReaonlyvalue);
            Console.WriteLine("constValue : " + constValue);

        }

        public VaribleStaticReadonly()
        {

            readonlyvalue += "hari Guntu readonly value";
            Console.WriteLine(readonlyvalue);
        }
        public VaribleStaticReadonly(string Name)
        {

            readonlyvalue = Name;
            Console.WriteLine(readonlyvalue);
        }

    }
}
