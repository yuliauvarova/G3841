//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Метод читает данные от пользователя
uint ReadData(string msg)
{
    Console.WriteLine(msg);
    return uint.Parse(Console.ReadLine() ?? "0");
}

//Метод вычисляет функцию Аккермана
static uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

uint n = ReadData("Введите N: ");
uint m = ReadData("Введите M: ");
uint res = A(n,m);
Console.WriteLine();
Console.WriteLine(res);


