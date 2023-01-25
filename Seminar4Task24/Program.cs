// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

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

//Вводим данные
int numberA = ReadData("Введите число А: ");

int SumSimple(int numA)
{
    int sumOfNum = 1;

    for(int i=2; i<=numA; i++)
    {
        sumOfNum+=i;
    }
    return sumOfNum;
}

int SumGauss(int numA)
{
    return (numA*(numA+1))/2;
}


DateTime d1 = DateTime.Now;
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до А(SumSimple): " + res1);
PrintData("Сумма чисел от 1 до А(SumGauss): " + res2);