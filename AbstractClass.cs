using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public abstract class  AbstractClass 
    {

        private readonly Guid _id;

        protected AbstractClass()
        {
            this._id = Guid.NewGuid();


        }

        public Guid ID {
            get
            {
                return this._id;
            }
        }
    }

   public class baseastract:AbstractClass
    {
        public baseastract()
        {

        }
    }

}
