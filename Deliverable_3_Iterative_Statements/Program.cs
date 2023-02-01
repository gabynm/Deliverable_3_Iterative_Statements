namespace Deliverable_3_Iterative_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input number
            int max = 0;
            // Infinite loop for valid data
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter integer between 1 to 100: ");
                    max = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Only integer numbers are allowed");
                }
            }

            // Input series odd or even
            Console.WriteLine("Specify series (Odd/Even): ");
            // Lower class it so user can enter series in any input
            string series = Console.ReadLine().ToLower();

            // Display the output
            Console.WriteLine("You have selected the ", series, " series. The numbers between 0 and ", max, " are:");
            // If series is odd
            if (series == "odd")
            {
                
                for (int i = 1; i <= max; i++)
                {
                    
                    if (i % 2 == 1)
                    {
                        
                        Console.WriteLine(i);
                    }
                }
            }
            // If series is even
            if (series == "even")
            {
                
                for (int i = 1; i <= max; i++)
                {
                    
                    if (i % 2 == 0)
                    {
                        
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}