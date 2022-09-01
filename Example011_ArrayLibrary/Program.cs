void FillArray(int[] Collection)

{
    int length = Collection.Length;
    int index = 0;
    while (index < length)
    {
        Collection[index] = new Random().Next(1, 10);
        //index = index +1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 7);
Console.WriteLine(pos);