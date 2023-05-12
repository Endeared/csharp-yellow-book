using System;

class AllFunctions
{
    static void Main()
    {
        InitialFunctions.DataTypes();
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
}