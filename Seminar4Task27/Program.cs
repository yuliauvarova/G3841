// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.

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

//Метод (ПРОСТОЙ) выдает сумму цифр в числе
int SumSymb1(int num)
{
    int result = 0;
    while(num>0)
    {
        result = result + num%10;
        num = num/10;
    }
    return result;
}


//Вводим число
int num = ReadData("Введите число: ");

//Считаем результат
int result = SumSymb1(num);

//Выводим результат на экран
PrintData("Сумма цифр числа " + num + " равна " + result + " (простой способ расчета)");

