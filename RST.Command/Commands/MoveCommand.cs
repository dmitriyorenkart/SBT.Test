using RST.Command.Context;
using RST.Command.Enums;
using RST.Command.Interfaces;
using RST.Command.Models;
using System;

namespace RST.Command.Commands
{
    public class MoveCommand : ICommand
    {
        public void Execute(IUnit unit)
        {
            if (unit is IMovingUnit movingUnit)
            {
                unit.Location = GetNewLocation(unit, movingUnit.CurrentMoveDirection, movingUnit.CurrentVelocity);
                Console.WriteLine($"{unit.GetType().Name} executed command {GetType().Name}: Moving unit position is now {unit.Location}");
            }
        }

        private Location GetNewLocation(IUnit unit, Direction direction, int velocity)
        {
            int xcoord = unit.Location.XCoord;
            int ycoord = unit.Location.YCoord;
            switch (direction)
            {
                case (Direction.Up):
                    ycoord += velocity;
                    break;
                case (Direction.Right):
                    xcoord += velocity;
                    break;
                case (Direction.Down):
                    ycoord -= velocity;
                    break;
                case (Direction.Left):
                    xcoord -= velocity;
                    break;
                default:
                    break;
            }

            if (xcoord >= FieldContext.FieldWIdth)
            {
                xcoord = FieldContext.FieldWIdth - 1;
            }
            if (xcoord < 0)
            {
                xcoord = 0;
            }

            if (ycoord >= FieldContext.FieldHeight)
            {
                ycoord = FieldContext.FieldHeight - 1;
            }
            if (ycoord < 0)
            {
                ycoord = 0;
            }

            return new Location(xcoord, ycoord);
        }
    }
}