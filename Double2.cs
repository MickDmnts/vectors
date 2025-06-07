namespace vectors {

    /// <summary>
    /// Represents a 2D vector
    /// </summary>
    public class Double2 {
        ///<summary>Degreest to Radians conversion value</summary>
        public const double DegToRad = MathF.PI / 180;

        ///<summary>Returns the X axis value</summary>
        public double X { get; private set; }
        ///<summary>Returns the Y axis value</summary>
        public double Y { get; private set; }

        public static Double2 Template = new Double2(double.NaN, double.NaN, -1);

        public int Index { get; private set; }

        public void SetX(double _x) {
            X = _x;
        }

        public void SetY(double _y) {
            Y = _y;
        }

        public void SetIndex(int _in) {
            Index = _in;
        }

        ///<summary>Returns the Unit (Direction) of the Double</summary>
       /* public Double2 Unit {
            get {
                double length = this.SqrMagnitude;
                return new Double2(X / length, Y / length);
            }
        }*/
        ///<summary>Returns the Squared Magnitude of the Double</summary>
        //public double SqrMagnitude => SquaredMagnitude(this);
        ///<summary>Returns the Magnitude of the Double</summary>
        //public double Length => Magnitude(this);

        ///<summary>Creates an instance of a Double with a value X, Y</summary>
        public Double2(double _x, double _y, int _index) {
            X = _x;
            Y = _y;
            Index = _index;
        }
        /*
                /// <summary>
                /// Adds two Double2 vectors together
                /// </summary>
                /// <param name="_v1">First vector to add</param>
                /// <param name="_v2">Second vector to add</param>
                public static Double2 Add(Double2 _v1, Double2 _v2) {
                    return new Double2(_v1.X + _v2.X, _v1.Y + _v2.Y);
                }

                /// <summary>
                /// Subtracts two Double2 vectors
                /// </summary>
                /// <param name="_v1">First vector to subtract</param>
                /// <param name="_v2">Second vector to subtract</param>
                public static Double2 Subtract(Double2 _v1, Double2 _v2) {
                    return new Double2(_v1.X - _v2.X, _v1.Y - _v2.Y);
                }

                /// <summary>
                /// Returns the dot product of two Double2 vectors
                /// </summary>
                /// <param name="_v1">First vector to multiply</param>
                /// <param name="_v2">Second vector to multiply</param>
                public static double Dot(Double2 _v1, Double2 _v2) {
                    return (_v1.X * _v2.X) + (_v1.Y * _v2.Y);
                }

                /// <summary>
                /// Returns the product of a Double2 vector
                /// I suppose that this is a way to change the direction of the vector?
                /// </summary>
                public static Double2 Product(Double2 _v, double _d) {
                    return new Double2(_v.X * _d, _v.Y * _d);
                }

                /// <summary>
                /// Returns the Squared Magnitude of a Double2 vector
                /// </summary>
                /// <param name="_v1">Vector to calculate the squared magnitude of</param>
                public static double SquaredMagnitude(Double2 _v1) {
                    double squareX = _v1.X * _v1.X;
                    double squareY = _v1.Y * _v1.Y;

                    return squareX + squareY;
                }

                /// <summary>
                /// Returns the Magnitude of a Double2 vector
                /// </summary>
                public static double Magnitude(Double2 _v1) {
                    return Math.Sqrt(SquaredMagnitude(_v1));
                }

                /// <summary>
                /// Returns the number between two double values
                /// </summary>
                public static double Lerp(double _a, double _b, double _t) {
                    return _a + _t * (_b - _a);
                }

                /// <summary>
                /// Returns the Double2 vector between two Double2 vectors based on a given t value
                /// </summary>
                public static Double2 Lerp(Double2 _v1, Double2 _v2, double _t) {
                    return new Double2(Lerp(_v1.X, _v2.X, _t), Lerp(_v1.Y, _v2.Y, _t));
                }

                /// <summary>
                /// Returns a new Double2 vector that is the result of rotating the original vector by a given angle
                /// </summary>
                public static Double2 Rotate(Double2 _v1, double _angle) {



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
 */
        public override string ToString() {
            return $"({X}, {Y})";
        }

    }
}
