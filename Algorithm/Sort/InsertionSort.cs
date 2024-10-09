namespace Sort;
internal static class InsertionSort<T> where T : IComparable<T>
{
    public static void Sort(T[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            T current = array[i];
            int j = i - 1;
            while (j >= 0 && array[j].CompareTo(current) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }
    }
}
