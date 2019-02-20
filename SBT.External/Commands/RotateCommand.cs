using RST.Command;

namespace SBT.External.Commands
{
	///<summary>
	/// Команда "Поворот". Применима ко всем игровым юнитам, реализующим интерфейс <see cref="ICommandTarget{RotateCommand}"/>.
	///</summary>
	public class RotateCommand : ICommand { }
}
