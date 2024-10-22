/* Command registry
 */

class Registry {
    Context context;
    ICommand fallback;
    Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();
    
    public Registry(Context context, ICommand fallback) {
        this.context = context;
        this.fallback = fallback;
    }
    
    public void Register(string name, ICommand command) {
        commands.Add(name, command);
    }
    
    public void Dispatch(string line) {
        string[] elements = line.Split(" ");
        string command = elements[0];
        string[] parameters = GetParameters(elements);
        (commands.ContainsKey(command) ? GetCommand(command) : fallback).Execute(context, command, parameters);
    }
    
    public ICommand GetCommand(string commandName) {
        return commands[commandName];
    }
    
    public string[] GetCommandNames() {
        return commands.Keys.ToArray();
    }
    
    private string[] GetParameters(string[] input) {
        return input.Skip(1).ToArray();
    }
}


/*Overall, the `Registry` class is designed to manage commands in a structured way,
allowing for easy registration and execution based on user input. It supports a fallback mechanism to handle unknown commands gracefully. */