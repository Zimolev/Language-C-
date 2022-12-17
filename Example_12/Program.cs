void FillArrae(int[] massiv)
{
    int index = 0;
    while (index < massiv.Length)
    {
        massiv[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        Console.Write(collection[i] + " ");
        i++;
    }
}

int IndexOf(int[] massiv, int find)
{
    int i = 0;
    int position = -1;
    while (i < massiv.Length)
    {
        if (massiv[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}

int[] array = new int[10];

FillArrae(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 0);
Console.WriteLine(pos);
