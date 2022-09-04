int size = 12;
int minValue = -9;
int maxValue = +9;
int[] array = new int[size];

for (int i = 0; i < array.Length; ++i) {
    array[i] = new Random().Next(minValue, maxValue +1);
}

//Console.WriteLine(string.Join(",", array));

int negativNumSum = 0;
int positivNumSum = 0;

foreach (int el in array) {
negativNumSum += el < 0 ? el : 0;
positivNumSum += el > 0 ? el : 0;
}

Console.WriteLine("Positiv sum: " + positivNumSum);
Console.WriteLine("Neganiv sum: " + negativNumSum);

