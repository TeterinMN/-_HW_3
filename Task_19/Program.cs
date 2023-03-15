System.Console.Clear();
System.Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(System.Console.ReadLine()!);
int reverseNumber = 0;
int temp = number;

while (number > 0)
{
    int digit = number % 10;
    reverseNumber = reverseNumber * 10 + digit;
    number /= 10;
}
if (temp >= 10000 && temp <= 99999)
{
    if (temp == reverseNumber)
    {
        System.Console.WriteLine($"Число {temp} - является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {temp} - не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Введено некорректное число");
}