//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводит результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

//Метод для определения кубов значений
String LineBilder(int n, int p)
{
    string result = "";
    for (int i = 1; i <= n; i++)
    {
        result += Math.Pow(i, p) + "\t";
    }
    return result;
}

//Вводим число
int num = ReadData("Введите число ");

//Собираем первую строчку
string line1 = LineBilder(num, 1);
//Собираем вторую строчку
string line2 = LineBilder(num, 3);

//Выводим данных
PrintData(line1, line2);