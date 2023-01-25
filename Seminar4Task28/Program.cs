// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
using System.Numerics;

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);

}

int num = ReadData("Введите число ");

BigInteger CalcFact(int num)
{
    BigInteger res = 1;
    for(int i=1; i<=num; i++)
        {
            res = res*i;
        }
    return res;
}

BigInteger res = CalcFact(num);

PrintData("Факториал равен " + res);