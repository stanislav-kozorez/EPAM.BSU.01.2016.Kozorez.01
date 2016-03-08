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
        public static void SortByRowSum(int[][] arr, SortOrder order)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (order == SortOrder.Ascendent)
                    {
                        if ((arr[j] == null) ||(arr[j + 1] != null && arr[j].Sum() > arr[j + 1].Sum()))
                        {
                            int[] temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                    else
                        if ((arr[j] == null) || (arr[j + 1] != null && arr[j].Sum() < arr[j + 1].Sum()))
                        {
                            int[] temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
        }

        public static void SortByMaxRowElement(int[][] arr, SortOrder order)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (order == SortOrder.Ascendent)
                    {
                        if ((arr[j] == null) || (arr[j + 1] != null && arr[j].Max() > arr[j + 1].Max()))
                        {
                            int[] temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                    else
                        if ((arr[j] == null) || (arr[j + 1] != null && arr[j].Max() < arr[j + 1].Max()))
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        public static void SortByMinRowElement(int[][] arr, SortOrder order)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (order == SortOrder.Ascendent)
                    {
                        if ((arr[j] == null) || (arr[j + 1] != null && arr[j].Min() > arr[j + 1].Min()))
                        {
                            int[] temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                    else
                        if ((arr[j] == null) || (arr[j + 1] != null && arr[j].Min() < arr[j + 1].Min()))
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

    }
}
