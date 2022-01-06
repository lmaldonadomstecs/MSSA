using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_5
{
    class B : A
    {
        public int b;

        public B ()
        {
            b = 20;
        }

        public int getSum()
        {
            return a + b;
        }
    }
}
