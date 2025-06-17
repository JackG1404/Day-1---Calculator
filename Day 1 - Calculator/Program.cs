// This is day 1 of coding a simple program each day in hopes i get better at programming and learn to use github

class Program
{
    static void Main(string[] args)
    {
        // Declaring variables
        int num1;
        int num2;
        string choice;

        // Getting user input for both numbers, and the operation they want to use for the calculation
        Console.WriteLine("Please enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter another number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("do you want to multiply, add, subtract or divide?: ");
        choice = Console.ReadLine();

        // Switch case to get the output and do a calculation based on whatever operation they picked
        switch (choice)
        {
            case "multiply":
                Console.WriteLine($"The output is: {num1 * num2}");
                break;
            case "add":
                Console.WriteLine($"The output is: {num1 + num2}");
                break;
            case "subtract":
                Console.WriteLine($"The output is: {num1 - num2}");
                break;
            case "divide":
                Console.WriteLine($"The output is: {num1 / num2}");
                break;
        }

        // Waits until the user presses a key to close the console
        Console.ReadLine();
    }
}
