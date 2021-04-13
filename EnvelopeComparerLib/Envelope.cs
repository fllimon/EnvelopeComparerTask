using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeComparerLib
{
    public class Envelope
    {
        #region ======------ PRIVATE DATA ------=======

        private double _a = -1;
        private double _b = -1;

        #endregion

        #region ======------- CTOR ---------=======

        public Envelope(double a, double b)
        {
            _a = a;
            _b = b;
        }

        #endregion

        #region =====------ PROPERTIES ------======

        public double A
        {
            get 
            {
                return _a; 
            }
        }

        public double B
        {
            get
            {
                return _b;
            }
        }

        #endregion
    }
}
