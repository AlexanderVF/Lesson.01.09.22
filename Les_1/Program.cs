﻿int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;

//string concat = string.Join(",", arr);
//Console.WriteLine(concat);

string MyJoin(string delimeter, int[] array) {
    string result = "";
    for (int i = 0; i < array.Length - 1; ++i) {
        result = result + array[i] + delimeter;
    }
    result = result + array[array.Length - 1];

    return result;
}
Console.WriteLine(MyJoin);
