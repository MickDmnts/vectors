using vectors;

public static class Simulator {
    public static void SimulateBalistics(Double2 _startPos, Double2 _direction, double _speed, Double2 _gravityDirection, double _gravityAcceleration, int _runTime) {
        int time = 1;
        while (time <= _runTime) {
            Double2 newPos = _startPos + _direction * _speed * time + (_gravityDirection * _gravityAcceleration * time * time * 0.5);
            Console.WriteLine($"Time: {time} s, Position: {newPos}");
            time++;
        }
    }
    
    public static void SimulateSpiral(Double2 _startPos, int _runTime, double _degreesChange = 10d) {
        int time = 1;
        double degrees = 0;
        while (time <= _runTime) {
            Double2 position = Double2.Rotate(_startPos * time, degrees);
            Console.WriteLine($"Time: {time} s, Position: {position}");
            time++;
            degrees += _degreesChange % 360d;
        }
    }
}
