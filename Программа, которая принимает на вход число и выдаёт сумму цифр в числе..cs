//452 -> 11

//82 -> 10

//9012 -> 12

using System;
using static System.Console;

Clear();
Write("Введите число: ");
string inputNumber = ReadLine();
int[] numbers = ConvertToIntArray(inputNumber);
WriteLine($"{inputNumber} -> {Sum(numbers)}");

int[] ConvertToIntArray(string str) {
    int[] numbers = new int[str.Length];
    for(int i = 0; i < str.Length; i++) {
        numbers[i] = (int) Char.GetNumericValue(str[i]);
    }
    return numbers;
}

int Sum(int[] numbers) {
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++) {
        sum += numbers[i];
    }
    return sum;
}

