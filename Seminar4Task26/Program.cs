// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

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

int num = ReadData("Введите число: ");

int SumDigit(int num)
{
    int res = 0;
    while(num >0)
    {
        res++;
        num = num/10;
    }
    return res;
}

int res1 = SumDigit(num);

PrintData("Количество цифр в числе " + res1);

int DigitStr(int num)
{
    int res = 0;
    res = num.ToString().Length;
    return res;
}

int res2 = DigitStr(num);

PrintData("Количество цифр в числе " + res2);