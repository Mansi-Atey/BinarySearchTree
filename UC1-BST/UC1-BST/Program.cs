using System;

namespace UC1_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BST binarySearchTree = new BST();
            binarySearchTree.Insert(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
        }
    }
}
