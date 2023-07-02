# Hierarchical structure
**By: Fourthram Kaimo**


Given a specific tree structure, calculate the depth using recursion.

---

## Solution

1. Define the node that it have a value and three children, left child, middle child, and the right child.
2. Create an insertion method with two functions:
   1. `Insert()` is a helper function that will call a recursive function `InsertItem()`
   2. `InsertItem()` is a recursive function that inserts the node to the tree. 
   >If the value of the new node is less than the parent node it will be inserted in the left child of that node. 
   > If their value is equal, then it is inserted as a middle child. Otherwise if it greater than the value of the parent node, it will be inserted as the right child.

3.Find the depth of the tree by using the `maxDepth()` function. It recursively traverse the right, left, and middle children until the farthest node. Then the function will return a +1 if the tree is not null and the maximum value in comparison to the depth of each children, left, right, and middle.

