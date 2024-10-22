/* Fallback for when a command is not implemented
 */

class CommandUnknown : BaseCommand, ICommand {
    public void Execute(Context context, string command, string[] parameters) {
        Console.WriteLine("Woopsie, I don't understand '" + command + "' 😕");
    }
}

//The purpose of this class and method is to handle cases where an unrecognized command is received.