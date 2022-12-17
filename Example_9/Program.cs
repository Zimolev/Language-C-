int Max(int arg1, int arg2, int agr3) 
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (agr3 > result) result = agr3;
    return result;
}
int a1 = 1;
int a2 = 10;
int a3 = 11;
int a4 = 16;
int a5 = 170;
int a6 = 1;
int a7 = 10;
int a8 = 7;
int a9 = 29;
/*
int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);*/

int max = Max(
    Max(a1, a2, a3), 
    Max(a4, a5, a6), 
    Max(a7, a8, a9)
    );

Console.WriteLine(max);

/*int max = a1;
if (a2 > max) max = a2;
if (a4 > max) max = a4;
if (a5 > max) max = a5;
if (a6 > max) max = a6;
if (a7 > max) max = a7;
if (a8 > max) max = a8;
if (a9 > max) max = a9;

Console.WriteLine(max);*/