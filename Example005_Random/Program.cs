// Знакомлюсь со случайным выбором чисел с помощью случайности RANDOM

int numberA = new Random().Next(1, 10); // Переменная А. Случайные числа 1, 2, 3....9. До 9-ти. Последняя не считается.
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10); // Переменная А. Случайные числа 1, 2, 3....9. До 9-ти. Последняя не считается.
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
