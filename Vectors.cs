namespace vectors {
    public struct Double2 {
        public double X => Vectors.Doubles._X[_Index];
        public double Y => Vectors.Doubles._Y[_Index];
        internal int _Index;

        public Double2(double _x, double _y) {
            _Index = Vectors.Create(_x, _y);
        }

        public Double2(int _idx) {
            _Index = _idx;
        }

        public static Double2 operator +(Double2 _lhs, Double2 _rhs) {
            int idx = Vectors.Sum(_lhs._Index, _rhs._Index);
            return new Double2(idx);
        }

        public override string ToString() {
            return $"({X}, {Y})";
        }
    }

    public struct Double2s {
        public double[] _X;
        public double[] _Y;

        public int _Length;

        public Double2s(int _length) {
            _Length = _length;

            _X = new double[_Length];
            _Y = new double[_Length];
        }
    }

    public static class Vectors {
        public const int LIMIT = 6_000_000;

        static Double2s DoublesCache = new Double2s(LIMIT);
        static int CountCache = 0;
        static Queue<int> DeletedIndexes = new Queue<int>();

        public static int Count => CountCache;
        public static Double2s Doubles => DoublesCache;

        internal static int Create(double _x, double _y) {
            int temp = CountCache;
            DoublesCache._X[temp] = _x;
            DoublesCache._Y[temp] = _y;

            CountCache++;

            return temp;
        }

        internal static int Sum(int _lhs, int _rhs) {
            double sumX = DoublesCache._X[_lhs] + DoublesCache._X[_rhs];
            double sumY = DoublesCache._Y[_lhs] + DoublesCache._Y[_rhs];
            return Create(sumX, sumY);
        }
    }
}
