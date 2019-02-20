using RST.Command.Commands;

namespace RST.Command.Units
{
	/// <summary>
	/// Игровой юнит типа "Автомобиль". Применимые команды: <see cref="MoveCommand"/>.
	/// </summary>
	public class Car : IUnit, ICommandTarget<MoveCommand>
	{
		public void ApplyCommand(MoveCommand command) => this.ApplyDefault(command);
	}
}
