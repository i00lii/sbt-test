namespace RST.Command
{
	public abstract class Command<TSelf> : ICommand
		where TSelf : class, ICommand
	{
		public void Execute(IUnit unit)
		{
			if (unit is ICommandTarget<TSelf> target)
			{
				target.ApplyCommand(this as TSelf);
			}
		}
	}
}