using Volume;

namespace VolumeTests
{
    public class VolumeTests
    {
        [Fact]
        public void BoxVolumeTest()
        {
            Box box = new(5);

            Assert.Equal(125, box.Volume());
        }

        [Fact]
        public void BallVolumeTest()
        {
            Ball ball = new(5);

            Assert.Equal(4*Math.PI*125/3, ball.Volume());
        }

        [Fact]
        public void CylinderVolumeTest()
        {
            Cylinder cylinder = new(5, 2);

            Assert.Equal(Math.PI * 20, cylinder.Volume());
        }

        [Fact]
        public void PyramidVolumeTest()
        {
            Pyramid pyramid = new(5, 6);

            Assert.Equal(10, pyramid.Volume());
        }

        [Theory]
        [InlineData(5, 10, 5)]
        [InlineData(2, 10, 5)]

        public void BoxAddTest(int side, int s, int h)
        {
            Box container = new(side);

            Program.FreeVolume = container.Volume();

            Pyramid pyramid = new(h, s);

            Assert.True(container.Add(pyramid));
        }
    }
}