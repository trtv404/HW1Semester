// Задача. Итоги блока. Выбор специализации.
using static System.Console;

Write("введите строку: ");
string[] inputString = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < inputString.Length; i++)
{
    if (inputString[i].Length <= 3) Write($"{inputString[i]}, ");
}