//3, 5 -> 243 (3⁵)

//2, 4 -> 16

using System;
using static System.Console;

int A = AskNumber("A");
int B = AskNumber("B");
WriteLine($"{A},{B} => {Exponentiation(A,B)}");

int AskNumber(string name) {
    Write($"Введите число {name}: ");
    return int.Parse(ReadLine());
}

int Exponentiation(int A, int B) {
    int result = 1;
    for(int i = 0; i < B; i++) {
        result = result*A;
    }
    return result;
}
