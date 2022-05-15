namespace Volume
{
    public class Pyramid : Shape
    {
        int _h;
        int _s;

        public int H
        {
            get { return _h; }
            init { _h = value; }
        }

        public int S
        {
            get { return _s; }
            init { _s = value; }   
        }

        public Pyramid(int h, int s)
        {
            H = h;
            S = s;
        }

        public override double Volume()
        {
            return _s * _h / 3;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Pyramid (s = {_s:f0}, h = {_h:f0)}, volume = {Volume():f2})");
        }
    }
}