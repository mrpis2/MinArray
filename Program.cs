class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 0, 5, 4, 2, 23, 54, 64, 22, 12 };
        int index = Min(array);
        Console.WriteLine("Gia tri nho nhat la: " + array[index] + " vi tri so: " + (index+1));

    }

    static int Min(int[] array)
    {
        int min = array[0];
        int index = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        return index;
    }
}