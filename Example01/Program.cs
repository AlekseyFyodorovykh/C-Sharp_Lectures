﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result=arg2;
    if(arg3 > result) result=arg3;
    return result;
}

int a1 =5;
int b1 =115;
int c1 =25;

int a2 =35;
int b2 =45;
int c2 =55;

int a3 =65;
int b3 =75;
int c3 =855;

/* int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3); */

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


Console.WriteLine(max);
