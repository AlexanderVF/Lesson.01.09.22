int size = 4;
int minValue = -9;
int maxValue = +9;
int[] array = new int[size];
for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", array));

/*Console.WriteLine();
array[i]= array[i] *(-1);
Console.WriteLine(string.Join(",", array));*/
for (int i = 0; i < array.Length; ++i)
{
    //array[i] = new Random().Next(minValue, maxValue + 1);
    array[i] = array[i]* (-1);
}
Console.WriteLine(string.Join(",", array));