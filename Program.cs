using vectors;

public class Program {
    static void Main(string[] args) {
        Vector2D vectorA = new Vector2D(5, 8);
        Vector2D vectorB = new Vector2D(16, 13);
        Vector2D sum = vectorA + vectorB;
        Vector2D sub = vectorB - vectorA;
        double dot = Vector2D.Dot(vectorA, vectorB);
        Vector2D prod = vectorA * 3;

        Console.WriteLine("A: " + vectorA);
        Console.WriteLine("B: " + vectorB);
        Console.WriteLine("A - B: " + sub);
        Console.WriteLine("Dot(A,B): " + dot);
        Console.WriteLine("Length A: " + vectorA.Length);
        Console.WriteLine("Length B: " + vectorB.Length);
        Console.WriteLine("Prod A * 3: " + prod);
        Console.WriteLine("Unit A: " + vectorA.Unit);
        Console.WriteLine("Length Unit A: " + vectorA.Unit.Length);
    }
}
