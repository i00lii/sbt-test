namespace RST.Command
{
	public interface ICommand
	{
		void Execute(IUnit unit);
	}
}