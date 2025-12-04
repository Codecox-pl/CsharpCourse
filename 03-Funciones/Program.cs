// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int a = 4;
int b = 9;
Show();
Sum(13, 2);
Console.WriteLine(Mul(6, 7));
Mul(6, 7);

static int Mul(int a, int b)
{
    int res = a * b;
    return res;
}
static void Sum(int x, int y)
{
    Console.WriteLine(x + y);
}

static void Show()
{
    Console.WriteLine("Texto de una funcion");
}


