/* Node class for modeling graphs
 */
using System;
using System.Collections.Generic;
using System.Linq;

class Node {
    protected string name;
    protected Dictionary<string, Node> edges = new Dictionary<string, Node>();

    public Node (string name) {		
        this.name = name;
    }

    public String GetName () {
        return name;
    }

    public void AddEdge (string name, Node node) {
        edges.Add(name, node);
    }

    public virtual Node FollowEdge (string direction) {
        return edges.TryGetValue(direction, out Node node) ? node : null;
    }
}



//Overall, this code provides a basic structure for creating and managing nodes in a graph, allowing for the addition of edges and traversal between nodes.