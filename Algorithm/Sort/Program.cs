namespace Sort;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nonSort = new[] { 4, 1, 3, 9, 7 };

        //BubbleSort<int>.Sort(nonSort);
        InsertionSort<int>.Sort(nonSort);
        foreach (var item in nonSort)
        {
            Console.WriteLine(item);
        }
    }
}
