// Напишите программу, которая на вход принимает число 
// и выдаёт его квадрат (число умноженное на само себя). 

Console.WriteLine("Введите число");
string? inputNum = Console.ReadLine();

if(inputNum!=null)
{
    int number = int.Parse(inputNum);

    //int result = number*number;
    int result = (int)Math.Pow(number,2);

    Console.WriteLine(result);

}