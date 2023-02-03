//Пользователь вводит с клавиатуры М чисел. 
//Посчитайте, сколько чисел больше 0 ввел пользователь.

//Метод читает данные от пользователя
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

//Метод для преобразования строки в строковой массив
string[] StringArray(string message)
{
    string[] words = message.Split(',');
    foreach (var word in words)
    {
        System.Console.WriteLine($"{word}");
    }
    return words;
}

//Метод подсчитывает количество положительных чисел
int CountPositives(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.Parse(array[i] ?? "0") > 0) { result = result + 1; }
    }
    return result;
}

//Выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}


string numbers = ReadData("Введите числа через запятую");
string[] words = StringArray(numbers);
int result = CountPositives(words);
PrintData("Число положительных чисел: " + result);