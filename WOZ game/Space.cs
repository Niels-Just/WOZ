/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {
    public Space (String name) : base(name)
    {
    }
  
    public void Welcome () {
        Console.WriteLine("You are now at " + name);
        Console.WriteLine("Current exits are:");
        foreach (String exit in edges.Keys) {
            Console.WriteLine(" - " + exit);
        }
    }
  
    public void Goodbye () {
        Console.WriteLine("Goodbye");
    }
}
