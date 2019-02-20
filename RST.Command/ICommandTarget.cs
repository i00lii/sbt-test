namespace RST.Command
{
	public interface ICommandTarget<TCommand>
		where TCommand : ICommand
	{
		void ApplyCommand(TCommand command);
	}
}
