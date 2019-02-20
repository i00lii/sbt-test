using RST.Command.Commands;

namespace RST.Command.Units
{
	public class Car : IUnit, ICommandTarget<MoveCommand>
	{
		public void ApplyCommand(MoveCommand command) => this.ApplyDefault(command);
	}
}
