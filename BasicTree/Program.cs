using System;
using System.Collections.Generic;

public class TreeNode//Fundamental building block that contains two parts
{
    public int Data { get; set; }//Data/Value to be stored in the node
    public List<TreeNode> Children { get; set; }//Child nodes

    public TreeNode(int data)//Constructor to create the TreeNode
    {
        Data = data;
        Children = new List<TreeNode>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create tree nodes
        TreeNode root = new TreeNode(1);
        TreeNode node2 = new TreeNode(2);
        TreeNode node3 = new TreeNode(3);
        TreeNode node4 = new TreeNode(4);
        TreeNode node5 = new TreeNode(5);
      
        // TreeNode node6 = new TreeNode(6);


        // Build the tree structure
        root.Children.Add(node2);
        root.Children.Add(node3);

        node2.Children.Add(node4);

        node3.Children.Add(node5);

        // The tree structure looks like this:
        //       1
        //      / \
        //     2   3
        //    /     \
        //   4       5

        // You can now traverse and work with the tree as needed.
        Console.WriteLine("Tree traversal:");

        TraverseTree(root);//Call method
    }

    static void TraverseTree(TreeNode node)
    {
        if (node == null)
            return;

        Console.Write(node.Data + " "); // Process the current node

        foreach (var child in node.Children)
        {
            TraverseTree(child); // Recursively traverse each child by going through the branches
        }
    }
}
