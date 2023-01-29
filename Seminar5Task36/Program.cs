// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.

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

void BubbleSort(int[] arr)
{
    int j=0;
    for(int k=0; k<arr.Length; k++)
    {
            for(int i=0; i<arr.Length-1; i++)
        {
            j=i+1;
            if(arr[i]>arr[j])
            {
                int temporary =arr[i];
                arr[i]=arr[j];
                arr[j]=temporary;
            }
        }
    }
}

//Метод считает сумму нечетных элементов
int SumOddElements(int[] arr)
{
    int result=0;
    for(int i=1; i<arr.Length; i=i+2)
    {
        result = result + arr[i];
    }
    return result;
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int[]arr = Gen1DArray(5,0,10);
Print1DArray(arr);
BubbleSort(arr);
Print1DArray(arr);
int result = SumOddElements(arr);
PrintData("Сумма элементов, стоящих на нечетных позициях, равна " + result);