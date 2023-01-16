// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.
//Считываем данные с консоли число1
string? inputNum1 = Console.ReadLine();
//Считываем данные с консоли число2
string? inputNum2 = Console.ReadLine();

//Проверяем, что данные не пустые
if((inputNum1!=null) && (inputNum2!=null))
{
    //Парсим введенное число1
    int number1 = int.Parse(inputNum1);
    //Парсим введенное число2
    int number2 = int.Parse(inputNum2);

    if(number1==number2*number2)
    {
        Console.WriteLine("Первое число -- квадрат второго");
    }
    else
    {
        Console.WriteLine("Первое число не квадрат второго");
    }
}