// Ввести числo, вывести, делится ли без остатка на 2.
Console.Clear();
Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
    Console.Write("Это число делится на 2 без остатка");
else
    Console.Write("Это число НЕ делится на 2 без остатка");