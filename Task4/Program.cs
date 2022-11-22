// Ввести 3 числа, вывести большее.
Console.Clear();
Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2, не равное числу 1: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3, не равное числам 1 и 2: ");
int l = Convert.ToInt32(Console.ReadLine());

while (n == m || n == l || m == l)
{
    Console.WriteLine("Вы ошиблись!\nВведите разные числа: ");
    Console.Write("Первое: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Второе: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Третье: ");
    l = Convert.ToInt32(Console.ReadLine());
}

if (n > m && n > l)
    Console.Write(n);
else if (n > m || m < l)
    Console.Write(l);
else
    Console.Write(m);