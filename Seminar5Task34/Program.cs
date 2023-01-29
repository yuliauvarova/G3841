// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

//Метод сортировки пузырьком
int[] SortSimple(int[] arr)
{
    int minPosition=int i;
    for(int i =0; i<arr.Length-1; i++)
    {
        if(arr[i]>arr[i+1])
        {
            
        }
    }
}

//Подметод на определение четности
bool IsEven(int n)
{
    return(n%2==0);
}

//Метод считает количество четных чисел в массиве
int CountEven(int[] arr)
{
    int result=0;
    for(int i=0; i<arr.Length; i++)
    {
        if(IsEven(arr[i]))
        {
            result=result+1;
        }
    }
    return result;
}

//Метод выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int[] arr = Gen1DArray(10, 100, 999);
Print1DArray(arr);
int result = CountEven(arr);
PrintData("Количество четных значений массива: " + result);