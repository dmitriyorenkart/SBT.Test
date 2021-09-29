using RST.Command.Models;

namespace RST.Command.Interfaces
{
    public interface IUnit
    {
        Location Location { get; set; }

        bool Selected { get; }
        void SwitchSelection();

        void ExecuteCommand(ICommand command);
    }
}