using System.ComponentModel;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value < Data) {
            // Check left subtree
            if (Left is null)
                return false;
            else 
                return Left.Contains(value);
        }
        else if (value > Data) {
            // Check right subtree
            if (Right is null)
                return false;
            else 
                return Right.Contains(value);
        }
        else
            return true;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        // Define variable for each subtree height
        int rightHeight = 1;
        int leftHeight = 1;

        if (Left is not null)  // Get height on left
            leftHeight = 1 + Left.GetHeight();

        if (Right is not null) // Get height on right
            rightHeight = 1 + Right.GetHeight();
    
        if (leftHeight >= rightHeight)  // Compare heights, and return proper number
            return leftHeight;
        else   
            return rightHeight;
    }
}