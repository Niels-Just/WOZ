/* Command for transitioning between spaces
 */

class CommandGo : BaseCommand, ICommand {
    public CommandGo() {
        description = "Follow an exit";
    }
    
    public void Execute(Context context, string command, string[] parameters) {
        if (GuardEq(parameters, 1)) {
            Console.WriteLine("I don't seem to know where that is 🤔");
            return;
        }
        context.Transition(parameters[0]);
    }
}

//the `CommandGo` class allows a user to attempt to move to a new location within the game