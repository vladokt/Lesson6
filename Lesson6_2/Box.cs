namespace Volume
{
    public class Box:Shape
    {
        int _h;

        public int H
        {
            get { return _h; }
            init { _h = value; }
        }

        public Box(int h)
        {
            H = h;
        }
        
        public override double Volume()
        {
            return Math.Pow(_h, 3);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Box (h = {_h.ToString("f0")}, volume = {Volume():f2})");
        }

        public bool Add(Shape shape)
        {
            if (Program.FreeVolume-shape.Volume()>=0)
            {
                Console.WriteLine("Shape is placed in the container");
                Program.FreeVolume -= shape.Volume();
                Console.WriteLine($"Container free volume: {Program.FreeVolume:f2}");
                return true;
            }
            else
            {
                Console.WriteLine("Shape is not placed in the container");
                return false;
            }
        }
    }
}
