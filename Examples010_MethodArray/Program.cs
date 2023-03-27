int[] array = {1, 12, 31, 24, 55, 36, 72, 18, 9};

int n = array.Length;
int find = 24;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"index данного числа = {index}");
        break;
    }

    index++;
}
