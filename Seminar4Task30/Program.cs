// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.

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

int len = ReadData("Укажите длину массива: ");
int[] arr = Gen1DArray(len, 0, 2);
Print1DArray(arr);