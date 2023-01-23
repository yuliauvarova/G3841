// //Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

int qNum = ReadData("Введите номер четверти");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

PrintQuterAnswer(qNum);

// if(qNum==1)
// {
//     Console.WriteLine("x>0,y>0");
// }
// if(qNum==2)
// {
//     Console.WriteLine("x>0,y<0");
// }
// if(qNum==3)
// {
//     Console.WriteLine("x<0,y<0");
// }
// if(qNum==4)
// {
//     Console.WriteLine("x<0,y>0");
// }



//Метод определяет диапазон точек по четверти
void PrintQuterAnswer(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("x>0,y>0");
        if (num == 2) Console.WriteLine("x>0,y<0");
        if (num == 3) Console.WriteLine("x<0,y<0");
        if (num == 4) Console.WriteLine("x<0,y>0");
    }
    else
    {
        Console.WriteLine("Вы ввели не номер четверти");
    }
}