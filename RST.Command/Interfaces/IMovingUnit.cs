using RST.Command.Commands;
using RST.Command.Enums;

namespace RST.Command.Interfaces
{
    public interface IMovingUnit : IUnit
    {
        Direction CurrentMoveDirection { get; }
        int CurrentVelocity { get; }

        void SetVelocity(int velocity);

        void SetDirection(Direction direction);
    }
}
