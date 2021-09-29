using RST.Command.Interfaces;
using System;

namespace RST.Command.Commands
{
    public class FireCommand : ICommand
    {
        public void Execute(IUnit unit)
        {

            if (unit is IFiringUnit firingUnit)
            {
                if (firingUnit.Target != null)
                {
                    firingUnit.Target.InflictDamage(firingUnit.Damage);
                    Console.WriteLine($"{unit.GetType().Name} executed command {GetType().Name}: target {firingUnit.Target.GetType().Name} hit.");

                }

                Console.WriteLine($"{unit.GetType().Name} executed command {GetType().Name}: No target");
            }

        }
    }
}
