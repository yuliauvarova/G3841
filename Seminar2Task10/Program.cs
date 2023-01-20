//Напишите программу, которая принимает на входе трехзначное число,
//а на выходе показывает вторую цифру этого числа.

int num = int.Parse(Console.ReadLine()??"0");

if(num<1000 && num>99)
{
    int result = num/10;
    result = result%10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
