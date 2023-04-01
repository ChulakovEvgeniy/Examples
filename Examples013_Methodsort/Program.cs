// Ctrl +K+C для закомментирования кода
// Ctrl +K+U и для раcкомментирования кода

int[] aru = { 1, 5, 3, 3, 9, 7, 2 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for( int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(aru);
SelectionSort(aru);
PrintArray(aru);



//System.Console.WriteLine($"{aru[i]} ");
