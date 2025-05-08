using vectors;

public class Program {
    static void Main(string[] _args) {
        Double2 startPos = new Double2(0, 0);
        Double2 direction = new Double2(1, 1);
        double initialVelocity = 1;
        Double2 gravityDirection = new Double2(0, -1);
        double gravityAcceleration = 1;
        Simulator.SimulateBalistics(startPos, direction, initialVelocity, gravityDirection, gravityAcceleration, 10);

        /*Double2 startPos = new Double2(1, 1);
        Simulator.SimulateSpiral(startPos, 36);*/

        /*Double2 v1 = new Double2(1, 1);
        Double2 v2 = new Double2(10, 7);

        Console.WriteLine($"v1: {v1}");
        Console.WriteLine($"v2: {v2}");
        Console.WriteLine($"v1 + v2: {v1 + v2}");
        Console.WriteLine($"v1 - v2: {v1 - v2}");
        Console.WriteLine($"v1 * 2: {v1 * 2}");
        Console.WriteLine($"Unit of v1: {v1.Unit}");
        Console.WriteLine($"Magnitude/Length of v1: {v1.Length}");
        Console.WriteLine($"Squared Magnitude of v1: {v1.SqrMagnitude}");
        Console.WriteLine($"Rotate v1 by 90 degrees: {Double2.Rotate(v1, 90d)}");
        Console.WriteLine($"Rotate v1 by 180 degrees: {Double2.Rotate(v1, 180d)}");
        Console.WriteLine($"Rotate v1 by 270 degrees: {Double2.Rotate(v1, 270d)}");
        Console.WriteLine($"Rotate v1 by 360 degrees: {Double2.Rotate(v1, 360d)}"); */
    }
}
