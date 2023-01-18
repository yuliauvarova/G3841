// Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

//Считываем данные с консоли 
string? N = Console.ReadLine();

//Делаем проверку на пустое значение
if (N!=null)
{
    //Парсим введенное число
    int outputNumber = int.Parse(N);

    string R = string.Empty;

    for(int i = 2; i < outputNumber; i = i+2)
    {
        R=R + i + ",";
    }

    if(outputNumber%2==0)
    { 
        R=R+outputNumber;
    }

        Console.WriteLine(R); 
}
    