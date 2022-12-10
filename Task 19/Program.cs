// task 19
Console.Clear();
//int n = new Random().Next (10000, 100000);
//Console.WriteLine ($"Сгенерированное число: {n}");
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = (n/10000); 
int b = n % 10; 
int c = (n/1000) % 10;
int d = (n/10) % 10;
if ((a == b) && (c == d))
    Console.WriteLine ("Это число является палиндромом");
else 
    Console.WriteLine ("Это число не является палиндромом");