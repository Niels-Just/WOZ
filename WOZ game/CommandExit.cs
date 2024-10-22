/* Command for exiting program
 */

class CommandExit : BaseCommand, ICommand {
    public CommandExit() {
        description = "Exit the game";
    }
    
    public void Execute(Context context, string command, string[] parameters) {
        context.MakeDone();
    }
}

/*the `CommandExit` class provides a way to encapsulate the logic for exiting an application,
allowing it to be executed in response to a specific command input. */