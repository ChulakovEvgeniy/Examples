Console.Clear();
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int posi = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            posi = index;
            break;
        }
        index++;
    }
    return posi;
}

int[] array = new int[10];
FillArray(array);
array[4] = 1;
array[9] = 1;//искуственно добавили 1 в рандомный массив
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);

Console.WriteLine(pos);