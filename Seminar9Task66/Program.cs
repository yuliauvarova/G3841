// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод вычисляет сумму рекурсивно
int RecSumMN(int m, int n)
{
    if(m>=n)
    {return n;}
    else
    {return m + RecSumMN(m+1,n);}
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int n=ReadData("Введите M: ");
int m=ReadData("Введите N: ");
int result=m<n ? RecSumMN(m,n):RecSumMN(n,m);
PrintData("Сумма равна " + result);