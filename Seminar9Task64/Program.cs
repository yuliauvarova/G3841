// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит натур числа от N до 1
string ReclineMN(int n)
{
    if(n<2)
    {return 1.ToString();}
    else
    {return n + " " + ReclineMN(n-1);}
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);

}

int n=ReadData("Введите N: ");
string result=ReclineMN(n);
PrintData(result);