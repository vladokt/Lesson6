namespace Perimeter
{
    public class Polygon
    {
        Point[] _vertex;

        public Point[] Vertex
        {
            get { return _vertex; }
            init { _vertex = value; }
        }
        public Polygon(Point[] points)
        {
            Vertex = points;
        }

        public double Perimeter()
        {
            double[] side = new double[_vertex.Length];

            for (int i = 0; i < _vertex.Length; i++)
            {
                if (i < _vertex.Length - 1)
                {
                    side[i] = Math.Sqrt(Math.Pow(_vertex[i + 1].X - _vertex[i].X, 2) + Math.Pow(_vertex[i + 1].Y - _vertex[i].Y, 2));
                    Console.WriteLine($"Side {_vertex[i].Name}-{_vertex[i + 1].Name} length: {side[i]:f4}");
                }
                else
                {
                    side[i] = Math.Sqrt(Math.Pow(_vertex[i].X - _vertex[0].X, 2) + Math.Pow(_vertex[i].Y - _vertex[0].Y, 2));
                    Console.WriteLine($"Side {_vertex[i].Name}-{_vertex[0].Name} length: {side[i]:f4}");
                }
            }

            return side.Sum();
        }

        public string Name()
        {
            switch (_vertex.Length)
            {
                case 3:
                    {
                        return "triangle";
                    }
                case 4:
                    {
                        return "quadrangle";
                    }
                case 5:
                    {
                        return "pentagon";
                    }
                default:
                    {
                        return "It's something else.";
                    }
            }
        }
    }
}
