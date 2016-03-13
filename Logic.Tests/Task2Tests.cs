using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Logic.Tests
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void SortByRowSum_AscendentOrder_ChangedInitialArray()
        {
            int[][] initial = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 7, 3 }, null, new int[] { 5, 7, 10, 7 } };
            int[][] expected = new int[5][] {new int[] { 1, 7, 3 }, new int[] { 5, 7, 10, 7 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, null};

            Task2.SortByRowSum(initial, SortOrder.Ascendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [TestMethod]
        public void SortByRowSum_DescendentOrder_ChangedInitialArray()
        {
            int[][] initial = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 7, 3 }, null, new int[] { 5, 7, 10, 7 } };
            int[][] expected = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 5, 7, 10, 7 }, new int[] { 1, 7, 3 }, null, null };

            Task2.SortByRowSum(initial, SortOrder.Descendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [TestMethod]
        public void SortByMaxRowElement_AscendentOrder_ChangedInitialArray()
        {
            int[][] initial = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 7, 3 }, null, new int[] { 5, 7, 10, 7 } };
            int[][] expected = new int[5][] { new int[] { 1, 7, 3 }, new int[] { 5, 7, 10, 7 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, null };

            Task2.SortByMaxRowElement(initial, SortOrder.Ascendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [TestMethod]
        public void SortByMaxRowElement_DescendentOrder_ChangedInitialArray()
        {
            int[][] initial = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 7, 3 }, null, new int[] { 5, 7, 10, 7 } };
            int[][] expected = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 5, 7, 10, 7 }, new int[] { 1, 7, 3 }, null, null };

            Task2.SortByMaxRowElement(initial, SortOrder.Descendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [TestMethod]
        public void SortByMinRowElement_AscendentOrder_ChangedInitialArray()
        {
            int[][] initial = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 7, 3 }, null, new int[] { 5, 7, 10, 7 } };
            int[][] expected = new int[5][] { new int[] { 1, 7, 3 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 5, 7, 10, 7 }, null, null };

            Task2.SortByMinRowElement(initial, SortOrder.Ascendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }

        [TestMethod]
        public void SortByMinRowElement_DescendentOrder_ChangedInitialArray()
        {
            int[][] initial = new int[5][] { new int[] { 8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 7, 3 }, null, new int[] { 5, 7, 10, 7 } };
            int[][] expected = new int[5][] { new int[] { 5, 7, 10, 7 }, new int[] { 8, 4, 7, 10, 9, 5, 20, }, new int[] { 1, 7, 3 }, null, null };

            Task2.SortByMinRowElement(initial, SortOrder.Descendent);

            for (int i = 0; i < initial.Length; i++)
                CollectionAssert.AreEqual(initial[i], expected[i]);
        }
    }
}
