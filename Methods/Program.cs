Add();
Console.WriteLine(Add2());


static void Add()
{
    Console.WriteLine("Added!");
}

static int Add2(int number1=10, int number2=30)
{
    return number1 + number2;
}