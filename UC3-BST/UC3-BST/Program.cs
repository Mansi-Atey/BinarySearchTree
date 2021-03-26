﻿using System;

namespace UC3_BST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BST binarySearchTree = new BST();
            binarySearchTree.Insert(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
            binarySearchTree.Display();
            bool result = binarySearchTree.IfExists(63, binarySearchTree);
            Console.WriteLine("size of binary search tree is : " + binarySearchTree.Size());
            Console.WriteLine(result + " found in binary search tree");
            Console.ReadKey();
        }
    }
}