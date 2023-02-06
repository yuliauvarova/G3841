// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерирует двумерный массив
int[,] Gen2DArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(1, 1000);
        }
    }
    return arr;
}

//Метод выводит двумерный массив на экран
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Метод читает и возвращает строку
string ReadDataString(string msg)
{
    Console.WriteLine(msg);
    string index = Console.ReadLine() ?? "0";
    return index;
}

//Метод преобразует строку в строковой массив
string[] StringArray(string message)
{
    string[] words = message.Split(',');
    foreach (var word in words)
    {
        System.Console.WriteLine($"{word}");
    }
    return words;
}

//Применяем методы
int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int[,] array = Gen2DArray(rows, columns);
Print2DArray(array);

string index = ReadDataString("Введите через запятую индексы элемента массива, значение которого нужно искать: ");
string[] words = StringArray(index);

//Парсим элементы строкового массива
int a = int.Parse(words[0]);
int b = int.Parse(words[1]);

//Определяем, есть ли в заданном массиве искомый элемент
if (a > rows || b > columns || a<0 || b<0)
{
    Console.WriteLine("Элемента с таким индексом в заданном массиве не существует.");
}
else
{
    Console.WriteLine(array[a,b]);
}