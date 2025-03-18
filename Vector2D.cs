namespace vectors {
    public struct Vector2D {

        public double X { get; private set; }
        public double Y { get; private set; }

        public Vector2D Unit {
            get {
                double length = this.SqrMagnitude;
                return new Vector2D(X / Length, Y / Length);
            }
        }

        public double SqrMagnitude => SquareMagnitude(this);
        public double Length => Magnitude(this);

        public Vector2D(double x, double y) {
            X = x;
            Y = y;
        }

        public static Vector2D Add(Vector2D v1, Vector2D v2) {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2D Subtract(Vector2D v1, Vector2D v2) {
            return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static double Dot(Vector2D v1, Vector2D v2) {
            return (v1.X * v2.X + v1.Y * v2.Y);
        }

        public static Vector2D Product(Vector2D v, double d) {
            return new Vector2D(v.X * d, v.Y * d);
        }

        public static double SquareMagnitude(Vector2D v1) {
            double squareX = v1.X * v1.X;
            double squareY = v1.Y * v1.Y;

            return squareX + squareY;
        }

        public static double Magnitude(Vector2D v1) {
            return Math.Sqrt(SquareMagnitude(v1));
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2) {
            return Add(v1, v2);
        }

        public static Vector2D operator -(Vector2D v1, Vector2D v2) {
            return Subtract(v1, v2);
        }

        public static Vector2D operator *(Vector2D v, double d) {
            return Product(v, d);
        }

        public override string ToString() {
            return $"({X}, {Y})";
        }
    }
}
