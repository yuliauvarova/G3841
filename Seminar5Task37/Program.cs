// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.

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

bool IsEven(int[] arr)
{
    return(arr.Length%2==0);
}

//
int[] MultipleArray(int[] arr)
{
    if(IsEven(arr))
    {
        int[] arrNew = new int[arr.Length/2];
            for(int i=0; i<arr.Length/2; i++)
            {
                arrNew[i] = arr[i]*arr[arr.Length-i-1];
            }
        return arrNew;
    }
    else
    {
        int[] arrNew = new int[arr.Length/2+1];        
            for(int i=0; i<arr.Length/2; i++)
            {
                arrNew[i] = arr[i]*arr[arr.Length-i-1];
            }
            arrNew[arrNew.Length-1]=arr[arr.Length/2]*arr[arr.Length/2];
        return arrNew;
    }
}

int[] arr = Gen1DArray(7,0,10);
Print1DArray(arr);
int[] newArr = MultipleArray(arr);
Print1DArray(newArr);