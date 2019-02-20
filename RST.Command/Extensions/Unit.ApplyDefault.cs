using System;

namespace RST.Command
{
	public static class UnitExtensions
	{
		public static void ApplyDefault<TUnit, TCommand>(this TUnit unit, TCommand command)
			where TUnit : IUnit
			where TCommand : ICommand
			=> Console.WriteLine($"{typeof(TUnit).Name}.{nameof(ICommandTarget<TCommand>.ApplyCommand)}({typeof(TCommand).Name} {nameof(command)})");
	}
}
