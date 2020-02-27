namespace NasaMarsRover.App.Model
{
    public class Position : IPosition
    {
        public Position(uint XCoordinate, uint YCoordinate)
        {
            this.XCoordinate = XCoordinate;
            this.YCoordinate = YCoordinate;
        }
        public uint XCoordinate { get; set; }
        public uint YCoordinate { get; set; }
    }
}