using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using static QuickSortLogic.QuickSort;


namespace QuickSortTest
{
    [TestClass]
    public class EvenMoreTests
    {
        [TestMethod]
        public void TestQuickSorting_GiveArray_SortedArray()
        {
            // Arrange
            int[] arr = new int[] { 1, 3, 4, 5, 6, 2, 5 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 5, 6 };
            Debug.WriteLine("Output the information in debug, if necessary.");

            // Act
            int[] actual = Quicksort(arr);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestQuickSorting_GiveOne_JustOne()
        {
            // Arrange
            int[] ar = new int[] { 1 };
            int[] expected = new int[] { 1 };
            Debug.WriteLine("Output the information in debug, if necessary.");

            // Act
            int[] actual = Quicksort(ar);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSorting_GiveNull_ThrowExeption()
        => Quicksort(null);
    }
}
