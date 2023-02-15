//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерирует двумерный массив
int[,] Gen2DArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
    return arr;
}

//Метод выводит двумерный массив на экран
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Метод перемножает две матрицы
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
 if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }



int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int[,] arr1 = Gen2DArray(rows,columns);
Print2DArray(arr1);
Console.WriteLine();
int[,] arr2 = Gen2DArray(rows,columns);
Print2DArray(arr2);
Console.WriteLine();
int[,] resultMatrix = MatrixMultiplication(arr1,arr2);
Print2DArray(resultMatrix);