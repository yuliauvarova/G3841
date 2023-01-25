// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерирует массив
int[] Gen1DArray(int len, int begin, int end)
{
    int[] arr = new int[len];
    Random gen = new Random();
    for(int i =0; i<len; i++)
    {
        arr[i]= gen.Next(begin, end);
    }
    return arr;
}

//Метод выводит на экран массив
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

//Вводим данные
int len = ReadData("Укажите длину массива: ");
int begin = ReadData("Укажите нижнюю границу значений массива: ");
int end = ReadData("Укажите верхнюю границу значений массива: ");

//Генерируем массив
int[] arr = Gen1DArray(len, begin, end);

//Выводим данные на экран
Print1DArray(arr);