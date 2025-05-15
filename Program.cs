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

<<<<<<< Updated upstream
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
=======
        double t = 0;
        while (t <= 1) {
            Console.WriteLine($"T {t:0.00}: " + Vector2D.Lerp(a, b, t));
            t += step;
        } */

        /* Vector2D a = new Vector2D(0, 0);
        Vector2D b = new Vector2D(6, 9);
        double step = 0.1;
        double t = 0;
        while (t <= 1) {
            Console.WriteLine($"T {t:0.00}: " + Vector2D.Lerp(a, b, t));
            t += step;
        } */

        /* double speed = 2;
        double time = 10;
        Vector2D start = new Vector2D(1, -1);
        Vector2D end = start * speed * time;
        Vector2D velocity = start * speed;
        Console.WriteLine("Start: " + start);
        Console.WriteLine("End: " + end);
        Console.WriteLine("Velocity: " + velocity);

        Console.WriteLine("Extrapolation: " + Vector2D.Lerp(start, velocity, 19)); */

        /* double speed = 2;
         double time = 10;
         Double2 start = new Double2(-3, -6);
         Double2 end = new Double2(-1, -7);
         Double2 dif = end - start;
         Double2 range = dif.Unit * speed * time;
         Double2 endNew = start + (dif.Unit * speed * time);*/
        /*
        Vector2 endNew = start.transform.position + (start.transform.forward * speed * time);
        */

        /* Double2 test = new Double2(1, 1);

         Double2 rot90 = Double2.Rotate(test, 90);
         Double2 rotM90 = Double2.Rotate(test, -90);

         Double2 rot180 = Double2.Rotate(test, 180);
         Double2 rotM180 = Double2.Rotate(test, -180);



         Console.WriteLine(" \nRotated 90: " + rot90);
         Console.WriteLine(" \nRotated M90: " + rotM90);
         Console.WriteLine(" \nRotated 180: " + rot180);
         Console.WriteLine(" \nRotated M180: " + rotM180);
        */
        /*Console.WriteLine("Start: " + start);
        Console.WriteLine("End: " + end);
        Console.WriteLine("Dif: " + dif);
        Console.WriteLine("Range: " + range);
        Console.WriteLine("End New: " + endNew);*/

        Vectors vec = new Vectors(100_000);
        Stopwatch sw = new Stopwatch();
        sw.Start();
        double x = 0;
        double y = 0;
        for (int i = 0; i < vec.VectorLimit; i++) {
            vec.Create(x, y);
            x++;
            y++;
        }
        sw.Stop();
        Console.WriteLine("Creating: " + sw.Elapsed);
>>>>>>> Stashed changes
    }
}
