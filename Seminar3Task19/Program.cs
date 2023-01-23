// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

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

//Метод, определяет, палиндром ли это
bool PalinTest(int n)
{
    bool result = false;
    int d1 = n/10000;
    int d2 = (n/1000)%10;
    int d3 = (n/10)%10;
    int d4 = n%10;
    result = ((d1==d4) && (d2==d3))?true:false;
    return result;
}

//Вводим число
int n = ReadData("Введите пятизначное число: ");

//Применяем метод к n
bool res = PalinTest(n);

//Выводим результат
if(res)
{ 
    PrintData("Палиндром");
}
else
{
    PrintData("Не палиндром");
}
