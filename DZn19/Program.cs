Console.WriteLine("Введите число");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{
    if(number[0] == number [4] && number[1] == number[3])
    {
        System.Console.WriteLine("палиндром");
    }
    else
    {
        System.Console.WriteLine("не палиндром");
    }
}
else
{
    System.Console.WriteLine("число не пятизначное");
}