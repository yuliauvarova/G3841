﻿// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

//Вводим координаты точек
int x1 = ReadData("Введите координату X первой точки");
int y1 = ReadData("Введите координату Y первой точки");
int x2 = ReadData("Введите координату X второй точки");
int y2 = ReadData("Введите координату Y второй точки");

//Вычисляем длину
double len = CalcLen(x1,x2,y1,y2);

//Даем результат
PrintData("Расстояние между точками: ",len);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


//Выводит результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Вычисляем расстояние между точками в 2D пространстве
double CalcLen(int x1,int x2,int y1,int y2)
{
    double result =0;
    result = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return result;
}