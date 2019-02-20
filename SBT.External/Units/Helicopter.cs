using RST.Command;
using RST.Command.Commands;
using SBT.External.Commands;

namespace SBT.External.Units
{
	public class Helicopter : IUnit, ICommandTarget<MoveCommand>, ICommandTarget<RotateCommand>
	{
		public void ApplyCommand(RotateCommand command) => this.ApplyDefault(command);
		public void ApplyCommand(MoveCommand command) => this.ApplyDefault(command);
	}
}
