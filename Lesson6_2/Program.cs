namespace Volume
{
    public class Program
    {
        static double _freeVolume;
        public static double FreeVolume
        {
            get { return _freeVolume; }
            set { _freeVolume = value; }
        }
        public static void Main()
        {
            Console.Clear();
            Console.Write("Enter box side: ");
            int side = int.Parse(Console.ReadLine());
            
            Box container = new Box(side);
            Console.WriteLine($"Container volume: {container.Volume():f2}");

            _freeVolume = container.Volume();

            List<Shape> shape = new();

            Shape sh;
            bool isOk;

            do
            {
                Console.Write("Add shape in container (1 - box, 2 - cylinder, 3 - pyramid, 4 - ball): ");
                
                sh = AddShape(Console.ReadLine());
                
                isOk = container.Add(sh);

                if (isOk)
                {
                    shape.Add(sh);
                }
            } while (isOk);

            Console.WriteLine($"You put in container {shape.Count} shapes:");
            for (int i = 0; i < shape.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                shape[i].DisplayInfo();
            }
            Console.WriteLine($"Free volume: {_freeVolume:f2}");

            Console.ReadLine();
        }

        public static Shape AddShape(string type)
        {
            switch (type)
            {
                case "1":
                    {
                        Console.Write("Enter box side: ");
                        return new Box(int.Parse(Console.ReadLine()));
                    }
                case "2":
                    {
                        Console.Write("Enter cylinder radius: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.Write("Enter cylinder height: ");
                        int h = int.Parse(Console.ReadLine());
                        return new Cylinder(h, r);
                    }
                case "3":
                    {
                        Console.Write("Enter pyramid base area: ");
                        int s = int.Parse(Console.ReadLine());
                        Console.Write("Enter pyramid height: ");
                        int h = int.Parse(Console.ReadLine());
                        return new Pyramid(h, s);
                    }
                case "4":
                    {
                        Console.Write("Enter ball radius: ");
                        return new Ball(int.Parse(Console.ReadLine()));
                    }
                default:
                    {
                        return null;
                    }

            }
        }
    }
}