using System;
using NasaMarsRover.App.Enum;
using NasaMarsRover.App.Model;
using Xunit;

namespace NasaMarsRover.Test
{
    public class RoverScenarios
    {
        [Theory]
        [InlineData("LMLMLMLMM")]
        public void FirstCaseVerifyRover(string process)
        {
            Rover firstRover = new Rover(new Position(1, 2), new Plateau(5, 5), Directions.North);
            firstRover.Process(process);
            Assert.Equal(firstRover.Position.XCoordinate, (uint)1);
            Assert.Equal(firstRover.Position.YCoordinate, (uint)3);
            Assert.Equal(firstRover.Direction, Directions.North);
        }

        [Theory]
        [InlineData("MMRMMRMRRM")]
        public void SecondCaseVerifyRover(string process)
        {
            Rover firstRover = new Rover(new Position(3, 3), new Plateau(5, 5), Directions.East);
            firstRover.Process(process);
            Assert.Equal(firstRover.Position.XCoordinate, (uint)5);
            Assert.Equal(firstRover.Position.YCoordinate, (uint)1);
            Assert.Equal(firstRover.Direction, Directions.East);
        }
    }
}
