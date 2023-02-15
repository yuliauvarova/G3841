// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерирует двумерный массив
int[,,] Gen3DArray(int dim1, int dim2, int dim3)
{
    int[,,] arr = new int[dim1, dim2, dim3];
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                arr[i, j, k] = new Random().Next(1, 100);
            }
        }
    }
    return arr;
}

//Метод выводит двумерный массив на экран
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k +")" + "\t");
            }
            Console.WriteLine();
        }
    }
}

int dim1= ReadData("Введите длину первого измерения: ");
int dim2= ReadData("Введите длину второго измерения: ");
int dim3= ReadData("Введите длину третьего измерения: ");
int[,,] arr = Gen3DArray(dim1, dim2, dim3);
Print3DArray(arr);