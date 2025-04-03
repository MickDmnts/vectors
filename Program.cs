using vectors;

public class Program {
    static void Main(string[] _args) {
        /* Vector2D vectorA = new Vector2D(5, 8);
        Vector2D vectorB = new Vector2D(16, 0);
        Vector2D sum = vectorA + vectorB;
        Vector2D sub = vectorB - vectorA;
        Vector2D prod = vectorA * 3;
        Vector2D j = new Vector2D(0, 4);

        Console.WriteLine("A: " + vectorA);
        Console.WriteLine("B: " + vectorB);
        Console.WriteLine("A - B: " + sub);
        Console.WriteLine("Length A: " + vectorA.Length);
        Console.WriteLine("Length B: " + vectorB.Length);
        Console.WriteLine("Prod A * 3: " + prod);
        Console.WriteLine("Unit A: " + vectorA.Unit);
        Console.WriteLine("Length Unit A: " + vectorA.Unit.Length);
        Console.WriteLine("J: " + j);
        Console.WriteLine("Unit J, B: " + Vector2D.Dot(j.Unit, vectorB)); */

        /* double a = 3;
        double b = 69;
        double step = 0.1;

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

        double speed = 2;
        double time = 10;
        Double2 start = new Double2(-3, -6);
        Double2 end = new Double2(-1, -7);
        Double2 dif = end - start;
        Double2 range = dif.Unit * speed * time;
        Double2 endNew = start + (dif.Unit * speed * time);
        /*
        Vector2 endNew = start.transform.position + (start.transform.forward * speed * time);
        */

        Double2 test = new Double2(1, 1);

        Double2 rot90 = Double2.Rotate(test, 90);
        Double2 rotM90 = Double2.Rotate(test, -90);

        Double2 rot180 = Double2.Rotate(test, 180);
        Double2 rotM180 = Double2.Rotate(test, -180);



        Console.WriteLine(" \nRotated 90: " + rot90);
        Console.WriteLine(" \nRotated M90: " + rotM90);
        Console.WriteLine(" \nRotated 180: " + rot180);
        Console.WriteLine(" \nRotated M180: " + rotM180);

        /*Console.WriteLine("Start: " + start);
        Console.WriteLine("End: " + end);
        Console.WriteLine("Dif: " + dif);
        Console.WriteLine("Range: " + range);
        Console.WriteLine("End New: " + endNew);*/
    }
}
