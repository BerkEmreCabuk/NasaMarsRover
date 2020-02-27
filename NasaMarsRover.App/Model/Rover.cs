using System;
using NasaMarsRover.App.Enum;

namespace NasaMarsRover.App.Model
{
    public class Rover : IRover
    {
        public Rover(Position position, Plateau plateau, Directions direction)
        {
            this.Direction = direction;
            this.Plateau = plateau;
            PositionInitializer(position);
        }
        public Position Position { get; set; }
        public Plateau Plateau { get; set; }
        public Directions Direction { get; set; }
        public void Process(string commands)
        {
            try
            {
                foreach (var command in commands.Trim().ToUpper())
                {
                    switch (command)
                    {
                        case (Command.Left):
                            TurnLeft();
                            break;
                        case (Command.Right):
                            TurnRight();
                            break;
                        case (Command.Move):
                            Move();
                            break;
                        default:
                            throw new ArgumentException($"Invalid process : {command}");
                    }
                }
                WriteInformation($"Expected Output:");
            }
            catch (System.ArgumentException)
            {
                throw;
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException($"Process is failed. Exception : {ex}");
            }

        }

        private void TurnLeft()
        {
            if (this.Direction == Directions.North)
                this.Direction = Directions.West;
            else
                this.Direction--;
        }

        private void TurnRight()
        {
            if (this.Direction == Directions.West)
                this.Direction = Directions.North;
            else
                this.Direction++;
        }

        private void Move()
        {
            switch (Direction)
            {
                case (Directions.North):
                    this.Position.YCoordinate++;
                    CheckRoverInPlateau(this.Position);
                    break;
                case (Directions.East):
                    this.Position.XCoordinate++;
                    CheckRoverInPlateau(this.Position);
                    break;
                case (Directions.South):
                    this.Position.YCoordinate--;
                    CheckRoverInPlateau(this.Position);
                    break;
                case (Directions.West):
                    this.Position.XCoordinate--;
                    CheckRoverInPlateau(this.Position);
                    break;
                default:
                    throw new ArgumentException($"Invalid direction : {Direction}");
            }
        }

        private void PositionInitializer(Position position)
        {
            CheckRoverInPlateau(position);
            this.Position = position;
        }
        private void CheckRoverInPlateau(Position position)
        {
            if (position.XCoordinate > this.Plateau.Width
                || position.YCoordinate > this.Plateau.Height)
                throw new ArgumentException($"Rover's position isn't in plateau. Position XCoordinate : {position.XCoordinate} YCoordinate : {position.YCoordinate}");
        }
        private void WriteInformation(string message)
        {
            if (!string.IsNullOrEmpty(message))
                Console.WriteLine(message);
            Console.WriteLine($"{this.Position.XCoordinate} {this.Position.YCoordinate} {this.Direction}");
        }
    }
}