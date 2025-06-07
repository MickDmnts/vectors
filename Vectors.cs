namespace vectors {
    public class Vectors {
        // An array containing the x coordinates
        //double[] _X;
        // An array containing the y coordinates
        //double[] _Y;

        List<double> _X;
        List<double> _Y;
        //List<int> _Index;

        // The max number of vectors we can have
        int _VectorLimit;
        // The actual number of vectors
        int _VectorCount;
        //The length of the list at the moment of its creation
        int _OriginalListCount = 0;

        Queue<int> _DeletedIndexes;

        public int VectorLimit => _VectorLimit;

        public Vectors(int _vectorLimit) {
            _VectorLimit = _vectorLimit;

            //_X = new double[_vectorLimit];
            //_Y = new double[_vectorLimit];
            //_Coordinates = new List<Double2>(_vectorLimit);
            _X = new List<double>(_VectorLimit);
            _Y = new List<double>(_VectorLimit);

            for (int i = 0; i < _VectorLimit; i++) {
                _X.Add(double.NaN);
                _Y.Add(double.NaN);
            }

            //_Index = new List<int>(_VectorLimit);
            _OriginalListCount = _vectorLimit;
            _DeletedIndexes = new Queue<int>(_vectorLimit);
            _VectorCount = 0;
        }

        //Creates a new Double2 and assigns and ID
        public Double2 Create(double _x, double _y) {

            //Double2 double2 = new Double2(_x, _y, _VectorCount);
            _X[_VectorCount] = _x;
            _Y[_VectorCount] = _y;
            //Console.WriteLine("Count: " + _X.Count);
            //_Index[_VectorCount] = _VectorCount;
            Double2.Template.SetX(_x);
            Double2.Template.SetY(_y);
            Double2.Template.SetIndex(_VectorCount);
            _VectorCount++;
            //LimitHandling();

            return Double2.Template;
        }

        /*public void DeleteVector(int _index) {
            _Coordinates[_index] = ;
            //_DeletedIndexes.Enqueue()
        }*/

        //public GetVector()

        //Ensures the number of Vectors does not exceed the limit
        void LimitHandling() {
            if (_VectorCount > _VectorLimit / 2) {

                // _Coordinates.AddRange(new Coordinates[_OriginalListCount]);
                _VectorLimit = _VectorCount;
            }
        }
    }
}
