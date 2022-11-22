// Ввести числo N, вывести все четные от 1 до N.
Console.Clear();
Console.Write("Введите натуральное число больше  1: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    if (i % 2 == 0)
    Console.Write($"{i} ");
    i++;
}

// if (n % 2 == 0)
//     Console.Write("Это число делится на 2 без остатка");
// else
//     Console.Write("Это число НЕ делится на 2 без остатка");