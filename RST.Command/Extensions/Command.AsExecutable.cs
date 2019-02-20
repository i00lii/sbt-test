namespace RST.Command.Extensions
{
	public static class CommandExtensions
	{
		public static IExecutable AsExecutable<TCommand>(this TCommand command)
			where TCommand : ICommand
			=> new Executable<TCommand>(command);

		private class Executable<TCommand> : IExecutable
			where TCommand : ICommand
		{
			private readonly TCommand _command;
			public Executable(TCommand command) => _command = command;

			public void Execute(IUnit unit)
			{
				if (unit is ICommandTarget<TCommand> target)
				{
					target.ApplyCommand(_command);
				}
			}
		}
	}
}
