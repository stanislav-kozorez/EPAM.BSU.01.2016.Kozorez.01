using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public enum SortOrder
    {
        Ascendent,
        Descendent
    }

    public static class Task2
    {
        private delegate int SortConditionDelegate(int[] arr);
        private static Dictionary<string, SortConditionDelegate> sortConditions;

        static Task2()
        {
            sortConditions = new Dictionary<string, SortConditionDelegate>();

            sortConditions.Add("Sum", Sum);
            sortConditions.Add("Max", Max);
            sortConditions.Add("Min", Min);
        }

        /// <summary>
        /// Sorts the array in ascendent/descendent order by the sum of each row
        /// </summary>
        public static void SortByRowSum(int[][] arr, SortOrder order) { Sort(arr, order, "Sum"); }

        /// <summary>
        /// Sorts the array in ascendent/descendent order by maximum element of each row
        /// </summary>
        public static void SortByMaxRowElement(int[][] arr, SortOrder order) { Sort(arr, order, "Max"); }

        /// <summary>
        /// Sorts the array in ascendent/descendent order by minimum element of each row
        /// </summary>
        public static void SortByMinRowElement(int[][] arr, SortOrder order) { Sort(arr, order, "Min"); }

        #region Private methods
        private static int Sum(int[] arr) { return arr.Sum(); }

        private static int Max(int[] arr) { return arr.Max(); }

        private static int Min(int[] arr) { return arr.Min(); }

        private static void Sort(int[][] arr, SortOrder order, string condition)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (order == SortOrder.Ascendent)
                    {
                        if ((arr[j] == null) || (arr[j + 1] != null && sortConditions[condition](arr[j]) > sortConditions[condition](arr[j + 1])))
                            Swap(arr, j);
                    }
                    else
                    {
                        if ((arr[j] == null) || (arr[j + 1] != null && sortConditions[condition](arr[j]) < sortConditions[condition](arr[j + 1])))
                            Swap(arr, j);
                    }
        }

        private static void Swap(int[][] arr, int index)
        {
            int[] temp = arr[index];
            arr[index] = arr[index + 1];
            arr[index + 1] = temp;
        }

        #endregion
    }
}
