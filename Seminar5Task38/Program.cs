// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.

//Метод генерирует массив вещественных чисел
double[] Gen1DArray(int len)
{
    double[] arr = new double[len];
    Random gen = new Random();
    for(int i =0; i<len; i++)
    {
        arr[i]= gen.NextDouble();
    }
    return arr;
}

//Метод выводит на экран массив
void Print1DArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

//Метод ищет разницу между максимумом и минимумом
double MinMaxDif(double[] arr)
{
    double max=double.MinValue;
    double min=double.MaxValue;
    for(int i=0; i<arr.Length-1; i++)
    {
        if(arr[i]<min)
        {
            min = arr[i];
        }
        if(arr[i]>max)
        {
            max =arr[i];
        }
    }
    return(max-min);
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);

}

double[]arr = Gen1DArray(20);
Print1DArray(arr);
double dif = MinMaxDif(arr);
PrintData("Разница между максимальным и минимальным значением: " + dif);
