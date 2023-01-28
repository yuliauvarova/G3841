// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

//Объявляем глобальные переменные
int positivSum=0;
int negativSum=0;

int[] testArr = Gen1DArray(12,-9,9);
NegPosSum(testArr);
Print1DArray(testArr);
PrintData("Сумма положительных чисел ", positivSum);
PrintData("Сумма отрицательных чисел ", negativSum);


//Выводит результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
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

//Метод считывает отриц и положит элементы
void NegPosSum(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]>0)
        {
            positivSum+=arr[i];
        }
        else
        {
            negativSum+=arr[i];
        }
    }
}