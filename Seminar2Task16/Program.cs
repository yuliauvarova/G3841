//Напишите программу, которая принимает на вход 2 числа и проверяет, является ли 
//одно квадратом другого.

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

if((num1==num2*num2) || (num2==num1*num1))
{
    Console.WriteLine("Одно из чисел является квадратом второго");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом второго");
}

TestSQRT(num1,num2);
TestSQRT(num2,num1);

void TestSQRT(int i, int j)
{
    if((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("Да, число " + j + "является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("число " + j + "не является квадратом числа " + i);
    }
}