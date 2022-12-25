int Sing(int a)
{
    if (a > 0)
        return 1;
    if (a < 0)
        return -1;
    return 0;
}

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int z = Sing(x) + Sing(y);
Console.WriteLine(z);