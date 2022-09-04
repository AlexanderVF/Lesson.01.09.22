int size = 4;
int minValue = 100;
int maxValue = 999;
int[] array = new int[size];
int x = 0;
for (int i = 0; i < array.Length; ++i) {
    array[i] = new Random().Next(minValue, maxValue);
}
//Console.WriteLine(string.Join(",", array));

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        int maxPosition = x;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
            if(array[j] > array[minPosition]) maxPosition = x;
            Console.Write($"{array[i]} + {array[x]} ");
        }
            Console.Write($"{array[i]} + {array[x]} ");
            //PrintArray(array);
        //int temprorary = array[i];
        //array[i] = array[minPosition];
        //array[minPosition] = temprorary;
    }
}

PrintArray(array);
