
int Max(int arg1, int arg2, int agr3) 
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (agr3 > result) result = agr3;
    return result;
}
int[] arrey = {1,29,37,43,56,662,27,38,9};
 
 int max = Max(
    Max(arrey[0], arrey[1], arrey[2]),
    Max(arrey[3], arrey[4], arrey[5]),
    Max(arrey[6], arrey[7], arrey[8])
);

Console.WriteLine(max);