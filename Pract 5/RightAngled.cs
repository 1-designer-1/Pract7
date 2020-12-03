using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_5
{
    class RightAngled : Pair
    {
        private int _firstKatet;
        private int _secondKatet;
        public RightAngled(int one, int two) : base(one, two)
        {
            _firstKatet = one;
            _secondKatet = two;
        }
        public new int First
        {
            get => _firstKatet;
            set { _firstKatet = value; }
        }
        public new int Second
        {
            get => _secondKatet;
            set { _secondKatet = value; }

        }
        public int Gupotenyza()
        {
            return (int)Math.Sqrt(First * First + Second * Second);
        }

        public double Ploshad()
        {
            return (double)First * Second / 2;
        }




    }
}
