using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTree;

namespace BinarySearchTreeTests
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void Add_Integer_returnsNode()
        {
            // Arrange
            int nbr = 47;
            Node node = new Node();
            Tree tree = new Tree();

            // Act
            tree.Add(nbr);

            // Assert

        }
        [TestMethod]
        public void Search_ValidInteger_returnsTrue()
        {
            // Arrange
            int nbr = 47;
            Node node = new Node();
            Tree tree = new Tree();

            // Act
            tree.Add(nbr);

            // Assert

        }
        [TestMethod]
        public void Search_InvalidInteger_returnsFalse()
        {
            // Arrange
            int nbr = 47;
            Node node = new Node();
            Tree tree = new Tree();

            // Act
            tree.Add(nbr);

            // Assert

        }
        [TestMethod]
        public void Traverse_Integer_returnsFalse()
        {
            // Arrange
            int nbr = 47;
            Node node = new Node();
            Tree tree = new Tree();

            // Act
            tree.Add(nbr);

            // Assert

        }
    }
}
