class DiceSimulator
{
    public static void Main()
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateRolls(numberOfRolls);

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / numberOfRolls;
            System.Console.WriteLine($"{i}: {new string('*', percentage)}");

        }

        System.Console.WriteLine($"\nTotal number of rolls = {numberOfRolls}.");
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}

class DiceRoller
{
    private Random random;

    public DiceRoller()
    {
        random = new Random();
    }

    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13]; 

        for (int i = 0; i < numberOfRolls; i++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        return results;
    }
}
