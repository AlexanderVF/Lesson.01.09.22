//Разница между максимальным и минимальным элементами массива
Console.Clear();
int size = 6;
double n = 0;
Random rand = new Random();
double[] array = new double[size];
double max = 0;
double min = 999;

for (int i = 0; i < array.Length; ++i) {
    
    array[i] = rand.NextDouble()*100;
}
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; i++) 

{
 
if (array[i] <= min) min = array[i];
if (array[i] > max) max = array[i];
    n = max - min;
}
Console.WriteLine(Math.Round(min, 2) + " -> min");
Console.WriteLine(Math.Round(max, 2) + " -> max");

Console.WriteLine(Math.Round(n, 2) + " -> Разница между максимальным и минимальным элементами массива");
