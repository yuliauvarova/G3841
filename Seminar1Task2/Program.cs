// Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

//Считываем данные с консоли 
string? numberA = Console.ReadLine();
string? numberB = Console.ReadLine();
if(numberA!=null && numberB!=null) 
{
    //Парсим введенное число1
    int NumA = int.Parse(numberA);
    int NumB = int.Parse(numberB);

//Сравниваем числа
        if(NumA>NumB)
        {
            Console.WriteLine("Первое число больше второго числа");
        }
        else
            if(NumB>NumA)
         {
            Console.WriteLine("Второе больше первого числа");
             }
            else 
            {
            Console.WriteLine("Числа равны");
            }

}