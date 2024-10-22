/* Context class to hold all context relevant to a session.
 */

class Context {
    private Space current;  // The current location (Space) the player is in
    private bool done = false;  // Whether the game is finished

    // Constructor to initialize the context with the starting space
    public Context(Space startSpace) {
        current = startSpace;
    }

    // Get the current space
    public Space GetCurrent() {
        return current;
    }

    // Transition to another space based on the direction provided
    public void Transition(string direction) {
        // Try to follow the edge (direction) from the current space
        Node nextNode = current.FollowEdge(direction);  // FollowEdge returns a Node

        // Check if nextNode is not null and can be cast to Space
        if (nextNode == null || !(nextNode is Space nextSpace)) {
            // If nextNode is null or not a Space, handle the error
            Console.WriteLine("You are confused, and walk in a circle looking for '" + direction + "'. In the end, you give up 😩");
        } else {
            // Move to the next space
            current.Goodbye();  // Say goodbye to the current space
            current = nextSpace;  // Set the current space to the new space (casted)
            current.Welcome();  // Welcome the user to the new space
        }
    }

    // Mark the game as done
    public void MakeDone() {
        done = true;
    }

    // Check if the game is finishedd
    public bool IsDone() {
        return done;
    }
}


//The provided code defines a class named `Context`, which is designed to manage the state of a user navigating through a series of interconnected spaces or nodes