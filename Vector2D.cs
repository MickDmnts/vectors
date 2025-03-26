namespace vectors {
    public struct Vector2D {

        public double X { get; private set; }
        public double Y { get; private set; }

        public const double DegToRad = MathF.PI / 180;

        public Vector2D Unit {
            get {
                double length = this.SqrMagnitude;
                return new Vector2D(X / Length, Y / Length);
            }
        }

        public double SqrMagnitude => SquareMagnitude(this);
        public double Length => Magnitude(this);

        public Vector2D(double _x, double _y) {
            X = _x;
            Y = _y;
        }

        public static Vector2D Add(Vector2D _v1, Vector2D _v2) {
            return new Vector2D(_v1.X + _v2.X, _v1.Y + _v2.Y);
        }

        public static Vector2D Subtract(Vector2D _v1, Vector2D _v2) {
            return new Vector2D(_v1.X - _v2.X, _v1.Y - _v2.Y);
        }

        public static double Dot(Vector2D _v1, Vector2D _v2) {
            return (_v1.X * _v2.X) + (_v1.Y * _v2.Y);
        }

        public static Vector2D Product(Vector2D _v, double _d) {
            return new Vector2D(_v.X * _d, _v.Y * _d);
        }

        public static double SquareMagnitude(Vector2D _v1) {
            double squareX = _v1.X * _v1.X;
            double squareY = _v1.Y * _v1.Y;

            return squareX + squareY;
        }

        public static double Magnitude(Vector2D _v1) {
            return Math.Sqrt(SquareMagnitude(_v1));
        }

        public static double Lerp(double _a, double _b, double _t) {
            return _a + _t * (_b - _a);
        }

        public static Vector2D Lerp(Vector2D _v1, Vector2D _v2, double _t) {
            return new Vector2D(Lerp(_v1.X, _v2.X, _t), Lerp(_v1.Y, _v2.Y, _t));
        }

        public static Vector2D Rotate(Vector2D _v1, double _angle) {

            /*double radAngle = _angle * DegToRad;
            double magn = Magnitude(_v1);
            double tanOriginalAngle = (_v1.Y / _v1.X);
            double Originalangle = Math.Atan(tanOriginalAngle);
            double newAngle = Originalangle + radAngle;
            double xNew = magn * Math.Cos(newAngle);
            double yNew = magn * Math.Sin(newAngle);*/

            return new Vector2D(Magnitude(_v1) * Math.Cos(Math.Atan((_v1.Y / _v1.X)) + _angle * DegToRad), Magnitude(_v1) * Math.Sin(Math.Atan((_v1.Y / _v1.X)) + _angle * DegToRad));
        }

        public static Vector2D operator +(Vector2D _v1, Vector2D _v2) {
            return Add(_v1, _v2);
        }

        public static Vector2D operator -(Vector2D _v1, Vector2D _v2) {
            return Subtract(_v1, _v2);
        }

        public static Vector2D operator *(Vector2D _v, double _d) {
            return Product(_v, _d);
        }

        public override string ToString() {
            return $"({X}, {Y})";
        }

    }
}
