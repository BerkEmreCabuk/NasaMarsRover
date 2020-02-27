namespace NasaMarsRover.App.Model
{
    public class Plateau : IPlateau
    {
        public Plateau(uint width, uint height)
        {
            this.Width = width;
            this.Height = height;
        }
        public uint Width { get; private set; }
        public uint Height { get; private set; }
    }
}