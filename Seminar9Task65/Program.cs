// Задайте значения M и N. Напишите программу, которая 
// найдёт все натуральные элементы в промежутке от M до N.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string ReclineMN(int m, int n)
{
    if(m>=n)
    {return n.ToString();}
    else
    {return m + " " + ReclineMN(m+1,n);}
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);

}

int n=ReadData("Введите N: ");
int m=ReadData("Введите M: ");
string result=ReclineMN(m,n);
PrintData(result);