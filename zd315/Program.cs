Console.WriteLine("Введите цифру обозначающую день недели ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7 )
Console.WriteLine("Это выходной день");
else Console.WriteLine("Это будний день");

