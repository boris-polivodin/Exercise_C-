// Console.WriteLine("Input first point");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second point");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third point");
// int x3 = Convert.ToInt32(Console.ReadLine());
// int y3 = Convert.ToInt32(Console.ReadLine());

int x1 = 30;
int y1 = 3;
int x2 = 1;
int y2 = 30;
int x3 = 80;
int y3 = 30;

Console.Clear();

Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");

Console.SetCursorPosition(x2, y2);
Console.WriteLine("+");

Console.SetCursorPosition(x3, y3);
Console.WriteLine("+");

int i = 0;
int a = x1, b = y1;
while (i <= 1000)
{
    int num = new Random().Next(0, 3);
    if (num == 0)
    {
        a = (a + x1)/2;
        b = (b + y1)/2;
    }
    if (num == 1)
    {
        a = (a + x2)/2;
        b = (b + y2)/2;
    }
    if (num == 2)
    {
        a = (a + x3)/2;
        b = (b + y3)/2;
    }
    Console.SetCursorPosition(a, b);
    Console.WriteLine("+");
    i++;
}
