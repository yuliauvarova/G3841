// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

int num = int.Parse(Console.ReadLine()??"0");

// int result1 = num%7;
// if(result1==0)
// {
//     int result2 = num%21;
//     if(result2==0) 
//     {
//         Console.WriteLine("Число кратно 7 и 21");
//     }
// }
// else
// {
// Console.WriteLine("Не кратно");
// }

int result1 = num%7;
int result2 = num%23;
if((result1==0) && (result2==0))
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
Console.WriteLine("Не кратно");
}