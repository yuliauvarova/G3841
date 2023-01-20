//Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет

Char[] digit = Console.ReadLine().ToCharArray();

if(digit.Length > 2)
{
    Console.WriteLine(digit[2]);
}
else
{
Console.WriteLine("Третьй цифры нет");
}