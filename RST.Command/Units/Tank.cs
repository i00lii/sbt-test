using RST.Command.Commands;

namespace RST.Command.Units
{
	public class Tank : IUnit, ICommandTarget<MoveCommand>, ICommandTarget<FireCommand>
	{
		public void ApplyCommand(MoveCommand command) => this.ApplyDefault(command);
		public void ApplyCommand(FireCommand command) => this.ApplyDefault(command);
	}
}