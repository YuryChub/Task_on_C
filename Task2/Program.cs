// Ввести 2 числа, вывести большее.
Console.Clear();
Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2, не равное числу 1: ");
int m = Convert.ToInt32(Console.ReadLine());

while (n == m)
{
    Console.Write("Вы ошиблись!\nВведите другое число 2: ");
    n = Convert.ToInt32(Console.ReadLine());

}

if (n > m)
    Console.Write(n);
else
    Console.Write(m);