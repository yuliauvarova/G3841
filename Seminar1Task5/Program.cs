// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

//Считываем данные с консоли 
string? imputNumLine = Console.ReadLine();
if(imputNumLine!=null) 
{
    //Парсим введенное число1
    int imputNumA = int.Parse(imputNumLine);
    int lastDigit = imputNumA%10;

    Console.WriteLine(lastDigit);
    
    int C = B*(-1);
    string R = string.Empty;

while(C<B)
{
    R = R + C + ",";
    C = C+1;
}

R = R + B ;
Console.WriteLine(R);
}