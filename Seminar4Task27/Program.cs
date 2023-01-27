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

//Метод (СТРОКОВОЙ) выдаем сумму чисел в строке
int SumSymb2(int num)
{
    int result2 = 0;
    char[] numArray = num.ToString().ToCharArray();
    int len = numArray.Length;
    for(int i=0; i<len; i++)
    {
        result2 = result2+int.Parse(numArray[i].ToString());
    }
    return result2;
}

//Вводим число
int num = ReadData("Введите число: ");

//Фиксируем время
DateTime d1 = DateTime.Now;
//Считаем результат, простой метод
int result = SumSymb1(num);
//Считаем время
Console.WriteLine(DateTime.Now - d1);


//Фиксируем время
DateTime d2 = DateTime.Now;
//Считаем результат, строковой метод
int result2 = SumSymb2(num);
//Считаем время
Console.WriteLine(DateTime.Now - d2);


//Выводим результат на экран
PrintData("Сумма цифр числа " + num + " равна " + result + " (простой способ расчета)");
PrintData("Сумма цифр числа " + num + " равна " + result2 + " (строковой способ расчета)");

