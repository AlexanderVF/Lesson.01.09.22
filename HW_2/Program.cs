/* int size = 4;
int minValue = 100;
int maxValue = 999;
int[] array = new int[size];

for (int i = 0; i < array.Length; ++i) {
    array[i] = new Random().Next(minValue, maxValue);
}
Console.WriteLine(string.Join(",", array));
 */


int size = 4;
int minValue = 100;
int maxValue = 999;
int[] array = new int[size];
//double array1 = Convert.ToDouble(array[i]);

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue);
    Console.Write(array[i] + ", ");
}
 Console.WriteLine();
 //double array1 = Convert.ToDouble(array[i]);
for (int i = 0; i < array.Length; i++)
{
    //double array = Convert.ToDouble(array[i]);
    array[i] = array[i] / 2;

    Console.Write(array[i] + ", ");
}

//Console.WriteLine(array[i]);
//Console.WriteLine(string.Join(",", array));

//i = 0;
//Console.WriteLine(array[i] / 2);
/* double c = double.Parse(Console.ReadLine());

Console.WriteLine("+"); */
/* if (c == 0) 
{
Console.WriteLine("Yes");
}
else 
{
Console.WriteLine("no");
}
 */