Console.WriteLine("Введите двух- или трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 100;
int c = a % 10;
int d = b % 10;
if (d>0)
Console.WriteLine($"третья цифра {c}");
else Console.WriteLine("третей цифры нет");
