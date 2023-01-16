// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел

//Считываем данные с консоли 
string? numberA = Console.ReadLine();
string? numberB = Console.ReadLine();
string? numberC = Console.ReadLine();

if (numberA!=null && numberB!=null && numberC!=null)
{
    //Парсим введенные числа
    int NumA = int.Parse(numberA);
    int NumB = int.Parse(numberB);
    int NumC = int.Parse(numberC);

//Сравниваем числа
        if(NumA>NumB)
        
        {
            if(NumA>NumC)
            Console.WriteLine("Первое число больше второго и третьего");
        }
        else
        if (NumB>NumC)
        {
            Console.WriteLine("Второе число больше первого и третьего");
        }
        else 
        Console.WriteLine("Третье число больше первого и второго");
}
          