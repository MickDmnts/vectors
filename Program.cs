using System.Diagnostics;
using vectors;

public class Program {
    static void Main(string[] _args) {
        Stopwatch sw = new Stopwatch();
        double x = 0;
        double y = 0;
        Console.WriteLine("Creating...");
        sw.Start();
        for (int i = 0; i < 100_000; i++) {
            new Double2(x, y);
            x++;
            y++;
        }
        sw.Stop();
        Console.WriteLine("Elapsed: " + sw.Elapsed);
        Console.WriteLine("Read...");
        sw.Start();
        for (int i = 0; i < Vectors.Count; i++) {
            Double2 temp = new Double2(i);
            x = temp.X;
            y = temp.Y;
            //Console.WriteLine(temp);
        }
        sw.Stop();
        Console.WriteLine("Elapsed: " + sw.Elapsed);
        Console.WriteLine("Sums...");
        sw.Start();
        for (int i = 0; i < 10000; i++) {
            Double2 lhs = new Double2(i);
            Double2 rhs = new Double2(i + 1);
            Double2 sum = lhs + rhs;
            //Console.WriteLine(sum);
        }
        sw.Stop();
        Console.WriteLine("Elapsed: " + sw.Elapsed);

        Double2 myDouble = new Double2(1, 2);
        Console.WriteLine(myDouble);
    }
}
