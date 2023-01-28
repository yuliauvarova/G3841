// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] testArr = Gen1DArray(12,-9,9);
Print1DArray(testArr);
InvArr(testArr);
Print1DArray(testArr);
int[] testArrNew = InvArrNew(testArr);

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

void InvArr(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i]*=(-1);
    }
}

int[] InvArrNew(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for(int i=0; i<arr.Length; i++)
    {
        newArr[i]=arr[i]*-1;
    }
    return newArr;
}