using vectors;

public static class Simulator {
    public static void SimulateBasilistics(Double2 _startPos, int _runTime) {
        int time = 1;
        double degrees = 0;
        while (time <= _runTime) {
            // Simulate the motion of the projectile
            Double2 position = Double2.Rotate(_startPos * time, degrees);
            Console.WriteLine($"Time: {time} s, Position: {position}");
            time++;
            degrees += 90d % 360d;
        }
    }
}
