using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeComparerLib
{
    public class EnvelopeComparer : IComparer<Envelope>
    {
        public int Compare(Envelope x, Envelope y)
        {
            if ((x.A > y.A) && (x.B > y.B) || (x.A > y.B) && (x.B > y.A))
            {
                return 1;
            }
            else
            {
                if ((x.A < y.A) && (x.B < y.B) || (x.A < y.B) && (x.B < y.A))
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
