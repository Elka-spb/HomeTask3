// Нахождение второго максимума последовательности, оканчивающейся на ноль
Console.Clear();
Console.WriteLine("Введите числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 0;
while (n != 0) // пока n не равно 0
{
    if (n > max1)
    {   max2 = max1;
        max1 = n; }
    n = Convert.ToInt32(Console.ReadLine());
    if (n < max1 && n > max2)
        max2 = n;
}
Console.WriteLine("Первый максимум " + max1);
Console.WriteLine("Второй максимум " + max2);