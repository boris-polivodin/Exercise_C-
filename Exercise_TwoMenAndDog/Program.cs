// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int  speedMan1 = 4, speedMan2 = 3, speedDog = 10, count = 0, i = 1;
double distance = 1000, time = 0, distanceDog = 0;

while (distance > 3)
{
    if (i == 1)
    {
        time = distance / (speedMan1 + speedDog);
        i = 2;
    }
    if (i == 2)
    {
        time = distance / (speedMan2 + speedDog);
        i = 1;
    }

    distance = distance - time * (speedMan1 + speedMan2);
    distanceDog += time * speedDog;

    count++;
    
}
Console.WriteLine(count);
Console.WriteLine(distanceDog);