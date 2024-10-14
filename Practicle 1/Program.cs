static void ProcessUserInput()
{
    Console.WriteLine("\n--- Task 1: Process User Input ---");
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Please enter your age: ");
    int age;
    if (int.TryParse(Console.ReadLine(), out age))
    {
        int ageInFiveYears = age + 5;
        Console.WriteLine($"Hello {name}, you are {age} years old, and in 5 years, you will be {ageInFiveYears} years old.");
    }
    else
    {
        Console.WriteLine("Invalid input for age.");
    }
}

static void SelectionStatements()
{
    Console.WriteLine("\n--- Task 2: Selection Statements ---");
    Console.Write("Please enter your age: ");
    int age;
    if (int.TryParse(Console.ReadLine(), out age))
    {
        if (age < 0 || age > 110)
        {
            Console.WriteLine("Invalid input. Please enter an age between 0 and 110.");
        }
        else if (age < 13)
        {
            Console.WriteLine("You are a child.");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are an adult.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

static void LogicalOperators()
{
    Console.WriteLine("\n--- Task 3: Logical Operators ---");
    Console.Write("Please enter an integer: ");
    int number;
    if (int.TryParse(Console.ReadLine(), out number))
    {
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

static void LeapYearChecker()
{
    Console.WriteLine("\n--- Task 4: Leap Year Checker ---");
    Console.Write("Enter a year: ");
    int year;
    if (int.TryParse(Console.ReadLine(), out year))
    {
        if (year < 0)
        {
            Console.WriteLine("Year cannot be negative.");
        }
        else if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

static void EvenOrOddChecker()
{
    Console.WriteLine("\n--- Task 5: Even or Odd Checker ---");
    Console.Write("Please enter an integer: ");
    int number;
    if (int.TryParse(Console.ReadLine(), out number))
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}
}