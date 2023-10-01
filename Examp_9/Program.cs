int Max (int arg1, int arg2, int arg3) 
{
int result = arg1;
if (arg2>result) result = arg2;
if (arg3>result) result = arg3;
return result;
}
//              0  1  2  3  4  5  6  7  8  9 
int[] array = {11,21,31,41,51,61,541,18,16,18,};
//array[0] = 12; // показано как можно обратиться к массиву и записать в него значение 

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max); // показано как обратиться к массиву и получить значение соответсвующего элемента