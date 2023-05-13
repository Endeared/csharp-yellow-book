using System;

class AllFunctions
{
    static void Main()
    {
        InitialFunctions.FirstLoop();
    }
}

class InitialFunctions
{
    public static void FirstFunction()
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet.");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres.");
    }

    public static void AssignValues()
    {
        int first, second, third;
        first = 1;
        second = 2;
        third = second + first;
        Console.WriteLine(third);
    }

    public static void DataTypes()
    {
        int i = 3, j = 2;
        float fraction;
        fraction = (float) i / (float) j;
        Console.WriteLine("fraction: " + fraction);
    }

    public static void ProgramsPatterns()
    {   
        Console.Write("How many tablets are there per bottle? ");
        string tablets = Console.ReadLine();
        Console.Write("What is the price per bottle? ");
        string price = Console.ReadLine();
        Console.Write("How many bottles are there? ");
        string bottles = Console.ReadLine();

        int tabletCount = int.Parse(tablets);
        int pricePerBottle = int.Parse(price);
        int bottleCount = int.Parse(bottles);

        int totalTablets = bottleCount * tabletCount;
        int salePrice = bottleCount * pricePerBottle;

        Console.WriteLine("The number of tablets is " + totalTablets + ".");
        Console.WriteLine("The total price is $" + salePrice + ".");
    }

    public static void GlazerCalculator()
    {
        double width, height, woodLength, glassArea;

        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;

        string widthString, heightString;

        Console.Write("Give the width of the window: ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        if (width < MIN_WIDTH) {
            Console.WriteLine("Width is too small.\n\n");
            Console.WriteLine("Using minimum... (" + MIN_WIDTH + ")");
            width = MIN_WIDTH;
        }

        if (width > MAX_WIDTH) {
            Console.WriteLine("Width is too large.\n\n");
            Console.WriteLine("Using maximum... (" + MAX_WIDTH + ")");
            width = MAX_WIDTH;
        }
        
        Console.Write("Give the height of the window: ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        if (height < MIN_HEIGHT) {
            Console.WriteLine("Height is too small.\n\n");
            Console.WriteLine("Using minimum... (" + MIN_HEIGHT + ")");
            height = MIN_HEIGHT;
        }

        if (height > MAX_HEIGHT) {
            Console.WriteLine("Height is too large.\n\n");
            Console.WriteLine("Using maximum... (" + MAX_HEIGHT + ")");
            height = MAX_HEIGHT;
        }

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet.");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres.");
    }

    public static void FirstLoop()
    {
        int i = 1;
        while (i < 11)
        {
            Console.WriteLine("The current number is " + i);
            i += 1;
        }
    }
}