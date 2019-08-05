using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWid_1()
        {
            BST<int> bst = GetBST();

            List<BSTNode<int>> list = bst.WideAllNodes();
        }

        [TestMethod]
        public void TestWid_2()
        {
            BST<int> bst = GetBST();
            bst.AddKeyValue(4, 200);
            bst.AddKeyValue(5, 200);
            bst.AddKeyValue(11, 200);
            bst.AddKeyValue(18, 200);

            List<BSTNode<int>> list = bst.WideAllNodes();

            BSTNode<int> lastLowest_node = new BSTNode<int>(0, 0, null);
            foreach (BSTNode<int> node in list)
                lastLowest_node = node;

            Assert.AreEqual(5, lastLowest_node.NodeKey);
        }


        [TestMethod]
        public void TestDeepMode0_1()
        {
            BST<int> bst = GetBST();
            List<BSTNode<int>> list = bst.DeepAllNodes(0);
            int[] keys = new int[] { 3, 6, 8, 9, 10, 12, 16, 19, 20, 23 };
            int counter = 0;
            Assert.AreEqual(10, list.Count);

            foreach (BSTNode<int> node in list)
            {
                Assert.AreEqual(keys[counter], node.NodeKey);
                counter++;
            }
        }

        [TestMethod]
        public void TestDeepMode1_1()
        {
            BST<int> bst = GetBST();
            List<BSTNode<int>> list = bst.DeepAllNodes(1);
            int[] keys = new int[] { 6, 3, 9, 12, 10, 8, 19, 23, 20, 16 };
            int counter = 0;

            Assert.AreEqual(10, list.Count);

            foreach (BSTNode<int> node in list)
            {
                Assert.AreEqual(keys[counter], node.NodeKey);
                counter++;
            }
        }

        [TestMethod]
        public void TestDeepMode2_1()
        {
            BST<int> bst = GetBST();
            List<BSTNode<int>> list = bst.DeepAllNodes(2);
            int[] keys = new int[] { 16, 8, 3, 6, 10, 9, 12, 20, 19, 23 };
            int counter = 0;

            Assert.AreEqual(10, list.Count);

            foreach (BSTNode<int> node in list)
            {
                Assert.AreEqual(keys[counter], node.NodeKey);
                counter++;
            }
        }


        [TestMethod]
        public void TestDeepMode2_2()
        {
            BST<int> bst = GetBST();
            bst.AddKeyValue(4, 200);
            bst.AddKeyValue(25, 200);
            bst.AddKeyValue(21, 200);
            bst.AddKeyValue(24, 200);

            List<BSTNode<int>> list = bst.DeepAllNodes(1);
            int[] keys = new int[] { 4, 6, 3, 9, 12, 10, 8, 19, 21, 24, 25, 23, 20, 16 };
            int counter = 0;

            Assert.AreEqual(14, list.Count);

            foreach (BSTNode<int> node in list)
            {
                Assert.AreEqual(keys[counter], node.NodeKey);
                counter++;
            }
        }

        /*
         *              16
         *          8       20
         *       3    10   19  23
         *        6  9  12
         * 
         * 
         */
        public BST<int> GetBST()
        {
            BST<int> bst = new BST<int>(null);
            bst.AddKeyValue(16, 100);
            bst.AddKeyValue(8, 100);
            bst.AddKeyValue(3, 100);
            bst.AddKeyValue(10, 100);
            bst.AddKeyValue(9, 100);
            bst.AddKeyValue(12, 100);
            bst.AddKeyValue(6, 100);
            bst.AddKeyValue(20, 100);
            bst.AddKeyValue(19, 100);
            bst.AddKeyValue(23, 100);
            return bst;
        }
    }
}
