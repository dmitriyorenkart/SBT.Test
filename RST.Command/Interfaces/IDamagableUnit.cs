namespace RST.Command.Interfaces
{
    public interface IDamagableUnit : IUnit
    {
        int CurrentHealth { get; }

        void InflictDamage(int amount);
     }
}
