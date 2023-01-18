Random nS = new Random();
int num = nS.Next(100,1000);
Console.WriteLine(num);
int digitfirst = num/100;
int digitlast = num%10;
Console.WriteLine(digitfirst*10+digitlast);
