//На входе 2числа: если 2 кратно первому, то ок, если нет - показать остаток от делания

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
int result = num2%num1;
if(result==0)
{
    Console.WriteLine("Кратное");
}
else
{
Console.WriteLine("Не кратно "+result);
}