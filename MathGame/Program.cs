Menu();

void Menu()

{
    Console.WriteLine("\nPlease enter your name");
    var name = Console.ReadLine();

    var date = DateTime.UtcNow;

    Console.WriteLine($"Hello {name} today is {date}, type any key to go to Menu");
    Console.ReadLine();

    var isGameOn = true;
    do
    {
        Console.Clear();
        Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
        Console.WriteLine("---------------------------------------------");

        var command = Console.ReadLine();

        switch (command)
        {
            case "a":
                Addition("\n Addition game selected");
                break;

            case "s":
                Substraction("Substraction game selected");
                break;

            case "d":
                Division(" \nDivision game selected");
                break;
        }
    } while (isGameOn);
}

void Addition(string message)
{
    Console.WriteLine(message);
    Console.Clear();
    int score = 0;
    for (int i = 0; i < 2; i++)
    {
        var random = new Random();

        int firstNum = random.Next(1, 10);

        int secondNum = random.Next(1, 10);

        Console.WriteLine($"{firstNum} + {secondNum}");

        var result = Console.ReadLine();

        if (int.Parse(result) == firstNum + secondNum)
        {
            Console.WriteLine("\n You are correct");
            score++;
        }
        else Console.WriteLine("\n You are incorrect");

        if (i == 1)
        {
            Console.WriteLine($"\n Your score is {score}. Type any key to go back to main menu");
            Console.ReadLine();
        }
    }
}

void Substraction(string message)
{
    Console.WriteLine(message);
    Console.Clear();
    int score = 0;
    for (int i = 0; i < 2; i++)
    {
        var random = new Random();

        int firstNum = random.Next(1, 10);

        int secondNum = random.Next(1, 10);

        Console.WriteLine($"{firstNum} - {secondNum}");

        var result = Console.ReadLine();

        if (int.Parse(result) == firstNum - secondNum)
        {
            Console.WriteLine("\n You are correct");
            score++;
        }
        else Console.WriteLine("\n You are incorrect");

        if (i == 1)
        {
            Console.WriteLine($"\n Your score is {score}. Type any key to go back to main menu");
            Console.ReadLine();
        }
    }
}
void Division(string message)
{
    Console.WriteLine(message);
    Console.Clear();
    int score = 0;
    for (int i = 0; i < 2; i++)
    {
        var divisionNumbers = GetDivisionNumbers();

        int firstNum = divisionNumbers[0];

        int secondNum = divisionNumbers[1];

        Console.WriteLine($"{firstNum} / {secondNum}");

        var result = Console.ReadLine();

        if (int.Parse(result) == firstNum / secondNum)
        {
            Console.WriteLine("\n You are correct");
            score++;
        }
        else Console.WriteLine("\n You are incorrect");

        if (i == 1)
        {
            Console.WriteLine($"\n Your score is {score}. Type any key to go back to main menu");
            Console.ReadLine();
        }
    }
}

int[] GetDivisionNumbers()
{
    var random = new Random();

    var firstNum = random.Next(1, 10);
    var secondNum = random.Next(1, 10);
    var result = new int[2];

    while (firstNum % secondNum != 0)
    {
        firstNum = random.Next(1, 10);
        secondNum = random.Next(1, 10);
    }

    result[0] = firstNum;
    result[1] = secondNum;

    return result;
}