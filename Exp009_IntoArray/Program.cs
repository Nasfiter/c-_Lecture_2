// данные из Exp008. запишим их в виде массива

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2355;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;
//             0    1   2  3   4   5   6   7   8
int[] array = { 12, 21, 39, 12, 23, 33, 13, 23, 33 };
array[0] = 100;
//array[4] = 50; // заменяет значение четветого элемента в массиве
//Console.WriteLine(array[4]);

int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result; 
}

int maxResult = Max(Max(array[0], array[1], array[2] ),
                 Max(array[3], array[4],array[5]), 
                 Max(array[6], array[7], array[8]));

Console.WriteLine($"Max = {maxResult}");

