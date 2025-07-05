

namespace oopvectors {

    public struct OOPDouble2 {
        double _X;
        double _Y;

        public double X => _X;
        public double Y => _Y;

        public OOPDouble2(double _x, double _y) {
            _X = _x;
            _Y = _y;
        }

        public static OOPDouble2 operator +(OOPDouble2 a, OOPDouble2 b) {
            return new OOPDouble2(a.X + b.X, a.Y + b.Y);
        }
        public override string ToString() {
            return $"({X}, {Y})";
        }
    }


    internal class OOPVectors {
        List<OOPDouble2> _Cache;

        public IReadOnlyList<OOPDouble2> OOPCache => _Cache;
        public int Count => _Cache.Count;
        public OOPVectors(int _limit) {

            _Cache = new List<OOPDouble2>(_limit);
        }

        public OOPDouble2 Create(double _x, double _y) {
            OOPDouble2 temp = new OOPDouble2(_x, _y);
            _Cache.Add(temp);
            return temp;
        }
    }
}
