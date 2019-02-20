namespace RST.Command
{
	/// <summary>
	/// Позволяет расширить поведение игрового юинта, позволяя применить к нему определенную <see cref="ICommand"/>
	/// </summary>
	public interface ICommandTarget<TCommand>
		where TCommand : ICommand
	{
		/// <summary>
		/// Применяет соответствующую <see cref="ICommand"/> к игровому юниту
		/// </summary>
		void ApplyCommand(TCommand command);
	}
}
