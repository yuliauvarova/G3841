// Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерирует массив
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    Random gen = new Random();
    for(int i =0; i<len; i++)
    {
        arr[i]= gen.Next(minValue , maxValue);
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

//Метод проверяет, есть ли заданное число в массиве
int Search(int[] arr, int e)
{
    int res = -1;
    for(int i=0; i<arr.Length; i++)
    if(arr[i]==e)
    {
        res = i;
        break;
    }
    return res;
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int[] testArr = Gen1DArray(12,-9,9);
Print1DArray(testArr);
int element = ReadData("Какой элемент найти? ");
int result = Search(testArr, element);

if (result>=0)
{
    PrintData("Элемент найдем в позиции: " + result);
}
else
{
    PrintData("Элемент не найден.");
}