// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.


//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод заполняет двумерный массив
int [,] Gen2DArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            arr[i,j] = i+j;
        }
    }
    return arr;
}

//Метод изменяет двумерный массив
void Update2DArray(int [,] arr)
{
    for(int i=0; i<arr.GetLength(0); i=i+2)
    {
        for(int j=0; j<arr.GetLength(1); j=j+2)
        {
            // if((i%2==0) && (j%2==0))
            // {
                arr[i,j]=(int)Math.Pow(arr[i,j],2);
           // }
        }
    }
}

void Print2DArray(int[,] arr)
{
    for(int rows = 0; rows<arr.GetLength(0); rows++)
    {
        for(int columns=0; columns<arr.GetLength(1); columns++)
        {
            Console.Write($"{arr[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int [,] arr = Gen2DArray(rows, columns);
Print2DArray(arr);
Console.WriteLine();
Update2DArray(arr);
Print2DArray(arr);