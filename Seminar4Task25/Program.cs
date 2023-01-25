// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

//Метод возводит первое число в степень второго
int Pow(int num1, int num2)
{
    int result = 1;
    while(num2>0)
    {
        result = result*num1;
        num2 = num2-1;
    }
    return result;
}

//Вводим 2 числа
int num1 = ReadData("Введите первое число: ");
int num2 = ReadData("Введите второе число: ");

//Возводим первое число в степень второго
int result = Pow(num1, num2);

//Выводим результат на экран
PrintData("Первое число в степени второго числа: " + result);