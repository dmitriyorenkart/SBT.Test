using RST.Command.Commands;
using RST.Command.Enums;
using RST.Command.Interfaces;
using RST.Command.Units;

namespace RST.Command
{
    public class Tank : UnitBase, IMovingUnit, IFiringUnit
    {
        protected Direction currentMovingDirection;

        protected int currentVelocity;

        protected IDamagableUnit target;

        protected int damage;


        public Tank(Direction currentMovingDirection, int currentVelocity, int damage)
        {
            this.currentMovingDirection = currentMovingDirection;
            this.currentVelocity = currentVelocity;
            this.damage = damage;
        }

        public Direction CurrentMoveDirection => currentMovingDirection;

        public int CurrentVelocity => currentVelocity;

        public IDamagableUnit Target => target;
        public int Damage => damage;

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