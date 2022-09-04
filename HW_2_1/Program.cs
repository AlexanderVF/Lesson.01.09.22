//Найти сумму элементов на нечетных позициях в массиве
Console.Clear();
int size = 4;
int minValue = 10;
int maxValue = 99;
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(minValue, maxValue);
}
Console.WriteLine(string.Join(",", array));

    for (int i = 0; i < array.Length; i++)
    {
    
        sum += i % 2 > 0 ? array[i] : 0;
    }


Console.WriteLine("В этом массиве [" + (string.Join(",", array) + "] сумма элементов на нечетных позициях -> " + sum));