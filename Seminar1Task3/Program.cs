// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

//Считываем данные с консоли число1
string? DayNumber = Console.ReadLine();
string[] dayWeek = new string[7];
dayWeek[0] = "понедельник";
dayWeek[1] = "вторник";
dayWeek[2] = "среда";
dayWeek[3] = "четверг";
dayWeek[4] = "пятница";
dayWeek[5] = "суббота";
dayWeek[6] = "воскресенье";

//Проверяем, что данные не пустые
if(DayNumber!=null) 
{
    //Парсим введенное число1
    int NameDay = int.Parse(DayNumber);
  

    Console.WriteLine(dayWeek[NameDay-1]);
}