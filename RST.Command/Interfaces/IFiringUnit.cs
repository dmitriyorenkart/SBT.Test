using RST.Command.Commands;

namespace RST.Command.Interfaces
{
    public interface IFiringUnit: IUnit
    {
        IDamagableUnit Target { get; }

        int Damage { get; }
    }
}
