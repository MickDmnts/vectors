namespace vectors {
    public class Vectors {

        struct Coordinates() {
            double _X;
            double _Y;
            //int index?
        }

        // An array containing the x coordinates
        //double[] _X;
        // An array containing the y coordinates
        //double[] _Y;

        List<Coordinates> _Coordinates;

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
            _Coordinates = new List<Coordinates>(_vectorLimit);
            _OriginalListCount = _vectorLimit;
            _DeletedIndexes = new Queue<int>(_vectorLimit);
            _VectorCount = 0;
        }

        //Creates a new Double2 and assigns and ID
        public Double2 Create(double _x, double _y) {

            Double2 double2 = new Double2(_x, _y, _VectorCount);
            _VectorCount++;
            LimitHandling();
            return double2;

        }

        /*public void DeleteVector(int _index) {
            _Coordinates[_index] = ;
            //_DeletedIndexes.Enqueue()
        }*/

        //public GetVector()

        //Ensures the number of Vectors does not exceed the limit
        void LimitHandling() {
            if (_VectorCount > _VectorLimit / 2) {

                _Coordinates.AddRange(new Coordinates[_OriginalListCount]);
                _VectorLimit = _VectorCount;

                //Not a fan, too many Vectors
                //Array.Resize(ref _X, _VectorCount);
                //Array.Resize(ref _Y, _VectorCount);
            }
        }


    }
}
