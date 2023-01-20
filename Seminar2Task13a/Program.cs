//Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет

int num = int.Parse(Console.ReadLine()??"0"); //Парсим число

if(num<100) //Проверка на трехначность
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int digit=0; //Вводим переменную "Разрядность"
    int numForDigit = num; //Вводим временную переменную 
    while(numForDigit>0) //Цикл на расчет разрядности
    {
        numForDigit = numForDigit/10;
        digit++;
    }
    Console.WriteLine("Разрядность числа " + digit);  

    if(digit>3) //Сокращаем исходное число до трехзначного
    {
        num = num/10*(digit-3);
    }
    
    int result = num%10; //Ищем остаток от деления на 10, это же третья цифра числа
    Console.WriteLine("Третья цифра " + result);
}