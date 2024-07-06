namespace AsciiGames
{
	public class UserCommandSelector
	{
		public UserCommandSelector()
		{
			_commands = new Commands();
			_menu = Command.EMenu.Main;
			
			SelectedCommand = Command.EId.None;
		}

		public Command.EId Select()
		{
			Command command;
			do
			{
				command = SelectCommand();
				if (command.ToMenu != Command.EMenu.None)
				{
					_menu = command.ToMenu;
				}
			} while (command.ToMenu != Command.EMenu.None);
			return command.Id;
		}


		private Command SelectCommand()
		{
			PrintCommands(_menu);
			Console.Write("Select command: ");
			Command? command;
			do
			{
				ConsoleKeyInfo input = Console.ReadKey();
				Console.WriteLine("");

				command = _commands.GetByKeyInMenu(input.Key, _menu);
				if (command == null)
				{
					Console.WriteLine("Invalid command");
					PrintCommands(_menu);
				}
			} while (command == null);
			return command;
		}


		public void PrintCommands(Command.EMenu menu)
		{
			Console.WriteLine($"===============   {Command.GetMenuName(menu)}   ===============");
			foreach (Command command in _commands.CommandList)
			{
				if (command.Menu == menu)
				{
					Console.Write($"{command.KeyString}: {command.Text}    ");
				}
			}
			Console.WriteLine();
		}

		private Command.EMenu _menu;

		public Command.EId SelectedCommand { get; set; }

		private readonly Commands _commands;
		
	}
}