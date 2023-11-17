namespace Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your date of birth (yyyy-MM-dd):");
            string userInput = Console.ReadLine();

            if (DateTime.TryParse(userInput, out DateTime dob))
            {
                // Successfully parsed the user input to a DateTime object
                Console.WriteLine($"You entered your date of birth as: {dob.ToShortDateString()}");
                // Now you can use the 'dob' variable, which is of type DateTime, for further processing
            }
            else
            {
                // Invalid date format entered by the user
                Console.WriteLine("Invalid date format. Please enter the date in the correct format (yyyy-MM-dd).");
            }

            // Rest of your code
        }
    }
    }
