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
        public int First1
        {
            get => _firstKatet;
            set { _firstKatet = value; }
        }
        public int Second2
        {
            get => _secondKatet;
            set { _secondKatet = value; }

        }
        public static RightAngled Gupotenyza(RightAngled first, RightAngled second)
        {
            return new RightAngled(first.First1 * first.First1, second.Second2 * second.Second2);
        }
        public static RightAngled operator +(RightAngled firstPair, RightAngled secondPair)
        {
            return new RightAngled(firstPair.First1 + secondPair.First1, firstPair.Second2 + secondPair.Second2);
        }
        public static double  Ploshad (RightAngled first, RightAngled second)
        {
            return (1 / 2 * (first.First1 * second.Second2));
        }




    }
}
