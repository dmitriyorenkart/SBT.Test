using RST.Command.Commands;
using RST.Command.Enums;
using RST.Command.Interfaces;
using RST.Command.Units;

namespace RST.Command
{
    public class Car : UnitBase, IMovingUnit
    {
        protected Direction currentMovingDirection;

        protected int currentVelocity;

        public Car(Direction currentMovingDirection, int currentVelocity)
        {
            this.currentMovingDirection = currentMovingDirection;
            this.currentVelocity = currentVelocity;
        }

        public Direction CurrentMoveDirection => currentMovingDirection;

        public int CurrentVelocity => currentVelocity;

        public void SetDirection(Direction direction)
        {
            currentMovingDirection = direction;
        }

        public void SetVelocity(int velocity)
        {
            currentVelocity = velocity;
        }
    }
}
