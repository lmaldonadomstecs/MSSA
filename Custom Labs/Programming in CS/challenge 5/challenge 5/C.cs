using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_5
{
    class C : A
    {
        public int c;

        public C()
        {
            c = 30;
        }

        public int getSum()
        {
            return a + c;
        }
    }
}
