namespace RST.Command
{
	/// <summary>
	/// Обобщенная сущность, позволяющая "вызвать" <see cref="ICommand"/> на определенном игровом юните.
	/// </summary>
	public interface IExecutable
	{
		/// <summary>
		/// Применяет действие к соответствующему <see cref="IUnit"/>
		/// </summary>
		/// <param name="unit"></param>
		void Execute(IUnit unit);
	}
}