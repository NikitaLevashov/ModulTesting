using System;
using System.Collections.Generic;
using System.Text;

namespace MainModelLibrary
{
    public static class ValueNull
    {
        public static string MethodFindNull(string value)
        {
            if(value == null)
            {
                throw new NullReferenceException("Value null");
            }

            return value;

        }

    }
}
