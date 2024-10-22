/* Baseclass for commands
 */

class BaseCommand {
    protected string description = "Undocumented";
  
    protected bool GuardEq (string[] parameters, int bound) {
        return parameters.Length!=bound;
    }
  
    public String GetDescription () {
        return description;
    }
}

/* The `BaseCommand` class provides a basic structure for command objects with a description
and a method to validate the number of parameters. It can be extended by other classes to create
specific command implementations, which can have their own descriptions and additional functionality.
*/