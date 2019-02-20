using System;

namespace RST.Command
{
	public static class UnitExtensions
	{
		/// <summary>
		/// Реализация действия "по умолчанию" для демонстрации вызова соответствующей команды на определенном игровом юните.
		/// </summary>
		public static void ApplyDefault<TUnit, TCommand>(this TUnit unit, TCommand command)
			where TUnit : IUnit
			where TCommand : ICommand
			=> Console.WriteLine($"{typeof(TUnit).Name}.{nameof(ICommandTarget<TCommand>.ApplyCommand)}({typeof(TCommand).Name} {nameof(command)})");
	}
}
