// Напишите программу, которая принимает на вход число,обозначающее
//день недели, а на выходе говорит, выходной ли это.

int day = int.Parse(Console.ReadLine()??"0"); //Парсим число

if(day>7 || day<1)
{
    Console.WriteLine("Это не день недели");
}
else
{
    if(day>5)
    {
        Console.WriteLine("Да, это выходной");
    }
    else
    {
        Console.WriteLine("Нет, это не выходной");
    }
}