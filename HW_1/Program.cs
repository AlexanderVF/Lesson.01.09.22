//Найти количество четных чисел в массиве
int size = 4;
int minValue = 100;
int maxValue = 999;
int[] array = new int[size];
int count = 0;

for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(minValue, maxValue);
}
//Console.WriteLine(string.Join(",", array));
    for (int i = 0; i < array.Length; i++)
    {
    
        count += array[i] % 2 == 0 ? 1 : 0;
    }


Console.WriteLine("В этом массиве [" + (string.Join(",", array) + "] количество четных чисел -> " + count));
