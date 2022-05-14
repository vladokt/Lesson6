namespace Perimeter
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.Write("Enter the number of vertices of the polygon (3-5): ");
            int number = int.Parse(Console.ReadLine());

            Point[] points = new Point [number];
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write($"Enter vertex {i + 1} name (e.g. A, B, C): ");
                string name = Console.ReadLine();

                Console.Write($"Enter vertex {i + 1} x coordinate: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write($"Enter vertex {i + 1} y coordinate: ");
                int y = int.Parse(Console.ReadLine());

                points[i] = new Point(x, y, name);
            }

            Polygon polygon = new (points);

            foreach (var item in polygon.Vertex)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Perimeter of {polygon.Name()}: {polygon.Perimeter():f4}");

            Console.ReadLine();
        }
    }
}