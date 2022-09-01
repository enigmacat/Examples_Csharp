int[] array = { 88, 4, 3, 7, 9, 11, 32, 16, 7 };
int n = array.Length;
int find = 7;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; //index + 1;
}