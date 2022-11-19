// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -7, 567, 89, 223-> 3

Console.Write("Введите 5 чисел (положительных, отрицательных, нулей). Используйте через пробел между числами: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int positiveNumbersCount = arr.Count(x => x > 0);
Console.WriteLine($"Количество чисел больше нуля равно: {positiveNumbersCount}");