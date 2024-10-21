using System;
public class Program
{
    static int number;

    public static void Main(string[] args) {TryAndCatch();}

    static void TryAndCatch()
    {
        try
        {
            Console.WriteLine("Please enter an integer 1-10.");
            number = int.Parse(Console.ReadLine());
            Switch();
        }
        catch (Exception e)
        {
            Console.WriteLine("That's not a number!");
            TryAndCatch();
        }
    }

    static void Switch()
    {
        Console.Write("Your number is ");
        switch(number)
        {
            case 1:
                Console.WriteLine("one.");
                break;
            case 2:
                Console.WriteLine("two.");
                break;
            case 3:
                Console.WriteLine("three.");
                break;
            case 4:
                Console.WriteLine("four.");
                break;
            case 5:
                Console.WriteLine("five.");
                break;
            case 6:
                Console.WriteLine("six.");
                break;
            case 7:
                Console.WriteLine("seven.");
                break;
            case 8:
                Console.WriteLine("eight.");
                break;
            case 9:
                Console.WriteLine("nine.");
                break;
            case 10:
                Console.WriteLine("ten.");
                break;
            default:
                Console.WriteLine("out of range!");
                TryAndCatch();
                break;
        }
    }
}