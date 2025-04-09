namespace vectors {
    public struct Double2 {

        public double X { get; private set; }
        public double Y { get; private set; }

        public const double DegToRad = MathF.PI / 180;

        public Double2 Unit {
            get {
                double length = this.SqrMagnitude;
                return new Double2(X / length, Y / length);
            }
        }

        public double SqrMagnitude => SquaredMagnitude(this);
        public double Length => Magnitude(this);

        public Double2(double _x, double _y) {
            X = _x;
            Y = _y;
        }

        public static Double2 Add(Double2 _v1, Double2 _v2) {
            return new Double2(_v1.X + _v2.X, _v1.Y + _v2.Y);
        }

        public static Double2 Subtract(Double2 _v1, Double2 _v2) {
            return new Double2(_v1.X - _v2.X, _v1.Y - _v2.Y);
        }

        public static double Dot(Double2 _v1, Double2 _v2) {
            return (_v1.X * _v2.X) + (_v1.Y * _v2.Y);
        }

        public static Double2 Product(Double2 _v, double _d) {
            return new Double2(_v.X * _d, _v.Y * _d);
        }

        public static double SquaredMagnitude(Double2 _v1) {
            double squareX = _v1.X * _v1.X;
            double squareY = _v1.Y * _v1.Y;

            return squareX + squareY;
        }

        public static double Magnitude(Double2 _v1) {
            return Math.Sqrt(SquaredMagnitude(_v1));
        }

        public static double Lerp(double _a, double _b, double _t) {
            return _a + _t * (_b - _a);
        }

        public static Double2 Lerp(Double2 _v1, Double2 _v2, double _t) {
            return new Double2(Lerp(_v1.X, _v2.X, _t), Lerp(_v1.Y, _v2.Y, _t));
        }

        public static Double2 Rotate(Double2 _v1, double _angle) {

            /*double radAngle = _angle * DegToRad;
            double magn = Magnitude(_v1);
            double tanOriginalAngle = (_v1.Y / _v1.X);
            double Originalangle = Math.Atan(tanOriginalAngle);
            double newAngle = Originalangle + radAngle;
            double xNew = magn * Math.Cos(newAngle);
            double yNew = magn * Math.Sin(newAngle);*/

            return new Double2(Magnitude(_v1) * Math.Cos(Math.Atan((_v1.Y / _v1.X)) + _angle * DegToRad), Magnitude(_v1) * Math.Sin(Math.Atan((_v1.Y / _v1.X)) + _angle * DegToRad));
        }

        public static Double2 operator +(Double2 _v1, Double2 _v2) {
            return Add(_v1, _v2);
        }

        public static Double2 operator -(Double2 _v1, Double2 _v2) {
            return Subtract(_v1, _v2);
        }

        public static Double2 operator *(Double2 _v, double _d) {
            return Product(_v, _d);
        }

        public override string ToString() {
            return $"({X}, {Y})";
        }

    }
}
