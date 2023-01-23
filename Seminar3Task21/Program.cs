// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

//Вводим координаты точек
int x1 = ReadData("Введите координату X первой точки");
int y1 = ReadData("Введите координату Y первой точки");
int z1 = ReadData("Введите координату Z первой точки");
int x2 = ReadData("Введите координату X второй точки");
int y2 = ReadData("Введите координату Y второй точки");
int z2 = ReadData("Введите координату Z второй точки");

//Вычисляем длину
double len = CalcLen(x1,x2,y1,y2,z1,z2);

//Даем результат
PrintData("Расстояние между точками: ",len);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


//Выводим результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Вычисляем расстояние между точками в 3D пространстве
double CalcLen(int x1,int x2,int y1,int y2, int z1, int z2)
{
    double result =0;
    result = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return result;
}