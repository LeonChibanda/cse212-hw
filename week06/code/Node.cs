using System.Diagnostics;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value == Data) {
            return;
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        bool found = false;
        Debug.WriteLine("Current: " + Data);
        if (value == Data) {
            found = true;
        }
        else if (value < Data)
        {
            if (Left is null)
                return false;
            else
                Debug.WriteLine("Left: " + Left.Data);
                return Left.Contains(value);
        } 
        else
        {
            if (Right is null)
                return false;
            else
                Debug.WriteLine("Right: " + Right.Data);
                return Right.Contains(value);
        }
        Debug.WriteLine(found + ": " + Data);
        return found;
    }

    public int GetHeight()
    {
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}