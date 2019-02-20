using RST.Command.Commands;

namespace RST.Command.Units
{
	/// <summary>
	/// Игровой юнит типа "Танк". Применимые команды: <see cref="MoveCommand"/>, <see cref="FireCommand"/>.
	/// </summary>
	public class Tank : IUnit, ICommandTarget<MoveCommand>, ICommandTarget<FireCommand>
	{
		public void ApplyCommand(MoveCommand command) => this.ApplyDefault(command);
		public void ApplyCommand(FireCommand command) => this.ApplyDefault(command);
	}
}