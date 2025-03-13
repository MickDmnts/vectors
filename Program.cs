using vectors;

public class Program {
    static void Main(string[] args) {
        Vector2D vectorA = new Vector2D(5, 8);
        Vector2D vectorB = new Vector2D(16, 13);
        Vector2D sum = vectorA + vectorB;

        Console.WriteLine(vectorA);
        Console.WriteLine(vectorB);
        Console.WriteLine(sum);
        Console.WriteLine("Sum Length: " + sum.Length);
    }
}
