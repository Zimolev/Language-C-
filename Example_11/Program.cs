int[] arrey = {1,29,37,43,56,662,27,38,9};

int n = arrey.Length;
int index = 0;
int find = 43;

while (index < n)
{
    if (arrey[index] == find)
    Console.WriteLine(index);
    break;
    index++;
}