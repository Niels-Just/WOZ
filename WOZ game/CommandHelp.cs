/* Help command
 */

class CommandHelp : BaseCommand, ICommand {
    Registry registry;
    
    public CommandHelp(Registry registry) {
        this.registry = registry;
        this.description = "Display a help message";
    }
    
    public void Execute(Context context, string command, string[] parameters) {
        string[] commandNames = registry.GetCommandNames();
        Array.Sort(commandNames);
        
        // find max length of command name
        int max = commandNames.Max(name => name.Length);
        
        // present list of commands
        Console.WriteLine("Commands:");
        foreach (string commandName in commandNames) {
            string description = registry.GetCommand(commandName).GetDescription();
            Console.WriteLine(" - {0,-" + max + "} " + description, commandName);
        }
    }
}

//The purpose of this class is to display a help message that lists all available commands in the system along with their descriptions. 