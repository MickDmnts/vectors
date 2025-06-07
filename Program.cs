using System.Diagnostics;
using vectors;

public class Program {
    static void Main(string[] _args) {

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
    }
}
