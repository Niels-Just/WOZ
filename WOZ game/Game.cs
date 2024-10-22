/* Main class for launching the game
 */

class Game {
    static World world = new World();
    static Context context = new Context(world.GetEntry());
    static ICommand fallback = new CommandUnknown();
    static Registry registry = new Registry(context, fallback);
    
    private static void InitRegistry() {
        ICommand cmdExit = new CommandExit();
        registry.Register("exit", cmdExit);
        registry.Register("quit", cmdExit);
        registry.Register("bye", cmdExit);
        registry.Register("go", new CommandGo());
        registry.Register("help", new CommandHelp(registry));
    }
    
    static void Main(string[] args) {
        Console.WriteLine("Welcome to the World of Zuul!");
        
        InitRegistry();
        context.GetCurrent().Welcome();
        
        while (!context.IsDone()) {
            Console.Write("> ");
            string? line = Console.ReadLine();
            if (line != null) registry.Dispatch(line);
        }
        Console.WriteLine("Game Over 😥");
    }
}

//Overall, this code sets up the infrastructure for a simple text-based adventure game, allowing players to interact with the game world through commands.