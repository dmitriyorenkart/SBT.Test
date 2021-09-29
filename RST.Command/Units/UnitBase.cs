using RST.Command.Interfaces;
using RST.Command.Models;
using System;
using System.Collections.Generic;

namespace RST.Command.Units
{
    public abstract class UnitBase : IUnit
    {
        private bool selected = false;
        private readonly IList<Type> commandReceiverTypes;
        public UnitBase()
        {
            Location = new Location(0, 0);
        }

        public UnitBase(Location location)
        {
            Location = location;
        }

        public bool Selected => selected;

        public Location Location { get; set; }

        public void SwitchSelection()
        {
            selected = !selected;
        }

        public void ExecuteCommand(ICommand command)
        {
            Console.WriteLine($"Unit {GetType().Name} received command: {command.GetType().Name}");
            command.Execute(this);
        }

    }
}
