using System;

namespace Advance_1
{
    class Lambada_Expressions
    {
        public int factorial(int l)
        {

            Func<int, int> call = null;
            call = x => x * (x == 1 ? 1 : call(x - 1));
            return(call(l));

        }
    }
}
