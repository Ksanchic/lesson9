//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана {Akkerman(m, n)}");

int Akkerman (int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman (m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));

}
