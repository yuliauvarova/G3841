// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

//Метод читает данные от пользователя
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

//Метод читает оператор от пользователя
char ReadData2(string msg)
{
    Console.WriteLine(msg);
    return char.Parse(Console.ReadLine() ?? "0");
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

//Метод возводит первое число в степень второго
double Pow(double num1, double num2)
{
    double result = 1;
    while(num2>0)
    {
        result = result*num1;
        num2 = num2-1;
    }
    return result;
}

//Вводим 2 числа
double num1 = ReadData("Введите первое число: ");
char operate = ReadData2("Введите знак математической операции: ");
double num2 = ReadData("Введите второе число: ");
double result=0;

//Выполняем оперцию в зависимости от того, какой знак 
if(operate == '^')
{
    //Возводим первое число в степень второго
    result = Pow(num1, num2);
}
if(operate == '-')
{
    //Вычитаем первое число из второго
    result = num1 - num2;
}
if(operate == '+')
{
    //Складываем оба числа
    result = num1 + num2;
}
if(operate == '*')
{
    //Умножаем числа
    result = num1 * num2;
}
if(operate == '/')
{
    //Делим первое число на второе
    result = num1/num2;
}

//Выводим результат на экран
PrintData("Результат операции: " + result);