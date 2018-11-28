# Graphs
## Description of Methods
### AddEdge()
- This method creates a new Edge between Vertices in the Graph. If a Vertex does not exist, this method will create it.

### GetNodes()
- This method returns a List of Vertices in the Graph.

### GetNeighbors()
- This method returns a List of Vertices that neighbor the target Vertex.

### Size()
- This method returns the number of Vertices in the Graph.

## Approach and Efficiency
### AddEdge()
- Big O Time: O(n) because we have to traverse the Graph to find the Vertex to add children to.
- Big O Space: O(1) because we are not allocating any new memory.

### GetNodes()
- Big O Time: O(n) because we have to traverse over the Graph to return all of the Vertices.
- Big O Space: O(n) because we are creating a List to return the Vertices.

### GetNeighbors()
- Big O Time: O(n) because we have to traverse over the Graph to return all of the Vertices that neighbor the target Vertex.
- Big O Space: O(n) because we are creating a List to return the neighboring Vertices.

### Size()
- Big O Time: O(1) because this method is constant time.
- Big O Space: O(1) because we are not allocatin any new memory.
