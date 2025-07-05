using System.Diagnostics;
using oopvectors;
using vectors;

public class Program {
    static void Main(string[] _args) {
        Stopwatch sw = new Stopwatch();
        double x = 0;
        double y = 0;
        Console.WriteLine("Creating...");
        sw.Start();
        for (int i = 0; i < 3_000_000; i++) {
            new Double2(x, y);
            x++;
            y++;
        }
        sw.Stop();
        Console.WriteLine("Elapsed: " + sw.Elapsed);
        sw.Reset();
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
        sw.Reset();
        Console.WriteLine("Sums...");
        sw.Start();
        for (int i = 0; i < 100_000; i++) {
            Double2 lhs = new Double2(i);
            Double2 rhs = new Double2(i + 1);
            Double2 sum = lhs + rhs;
            //Console.WriteLine(sum);
        }
        sw.Stop();
        Console.WriteLine("Elapsed: " + sw.Elapsed);
        sw.Reset();

        //.................OOPS.................//
        sw.Reset();
        OOPVectors oOPVector = new OOPVectors(3_000_000);
        Console.WriteLine("\nCreating OOP...");
        double oopX = 0;
        double oopY = 0;
        sw.Start();
        for (int i = 0; i < 3_000_000; i++) {
            oOPVector.Create(oopX, oopY);
            oopX++;
            oopY++;
        }
        sw.Stop();
        Console.WriteLine("OOP Elapsed: " + sw.Elapsed);
        sw.Reset();
        Console.WriteLine("OOP Read...");
        sw.Start();
        foreach (OOPDouble2 element in oOPVector.OOPCache) {
            oopX = element.X;
            oopY = element.Y;
        }
        sw.Stop();
        Console.WriteLine("OOP Elapsed: " + sw.Elapsed);
        sw.Reset();
        Console.WriteLine("Sums...");
        sw.Start();

        for (int i = 0; i < 100_000; i++) {
            OOPDouble2 a = oOPVector.OOPCache[i];
            OOPDouble2 b = oOPVector.OOPCache[i + 1];
            OOPDouble2 sum = a + b;
        }
        sw.Stop();
        Console.WriteLine("OOP Elapsed: " + sw.Elapsed);
        sw.Reset();
        //Double2 myDouble = new Double2(1, 2);
        //Console.WriteLine(myDouble);
    }
}
