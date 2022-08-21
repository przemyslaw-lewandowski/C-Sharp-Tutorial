ExploreIf();
ExploreLoops();
Challenge();

void ExploreIf()
{
    int a = 5;
    int b = 3;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10.");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    }

    int c = 4;
    if ((a + b + c > 10) && (a == b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
    }

    if ((a + b + c > 10) || (a == b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not euql to the second");
    }
}

void ExploreLoops()
{

    int counter = 0;
    while (counter < 10)
    {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
    }

    int counter2 = 0;
    do
    {
        Console.WriteLine($"Hello World! The counter is {counter2}");
        counter2++;
    } while (counter2 < 10);

    for (int index = 1; index < 10; index++)
    {
        Console.WriteLine($"Hello World! The index is {index}");
    }

    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }
}

void Challenge()
{
    int sum = 0;
    for (int number = 1; number < 21; number++)
    {
        if (number % 3 == 0)
        {
            sum = sum + number;
        }
    }
    Console.WriteLine(sum);
}