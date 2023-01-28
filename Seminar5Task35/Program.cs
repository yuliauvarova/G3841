// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

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

//Метод определяет количество элементов в отрезке
int QuantElements(int[] arr, int elFirst, int elSecond)
{
    int result = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i] >9 && arr[i]<100)
        {
            result = result+1;
        }
    }
    return result;
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int[] arr = Gen1DArray(123, 1, 100);
Print1DArray(arr);
int result = QuantElements(arr, 10, 99);
PrintData("Количество элементов в отрезке [10,99]: " + result);

//Второй вариант



bool Test(int n)
{
    return((n>9)&&(n<100));
}

int CountElements(int[] arr, int elFirst, int elSecond)
{
    int result1 = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if(Test(arr[i]))
        {
            result1 = result1+1;
        }
    }
    return result1;
}

int result1 = CountElements(arr, 10, 99);
PrintData("Второй вариант. Количество элементов в отрезке [10,99]: " + result1);