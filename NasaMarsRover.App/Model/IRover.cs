using NasaMarsRover.App.Enum;

namespace NasaMarsRover.App.Model
{
    public interface IRover
    {
        Position Position { get; }
        Plateau Plateau { get; }
        Directions Direction { get; }
    }
}