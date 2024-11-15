using System.Linq.Expressions;
namespace Practicing_Software_Development
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pre-made Dictionary phoneBook with 3 entries Ethan with a Small upodate by Jayson
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
        {
            {"Alvin", "555-1233"}, {"Brittany", "555-4567"}, {"Simon", "555-8910"}
        };

            Console.WriteLine("Welcome to your Phone Book");
            MainMenu();
            

            // Sort dictionary alphabetically by keys
            var sortedPhoneBook = phoneBook.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (KeyValuePair<string, string> pair in sortedPhoneBook)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            
        }
        // Jayson
        // Write out to the console the Menu Menu and handle the selected option
        static void MainMenu()
        {
            // write out menu
            Console.WriteLine("View PhoneBook \n    [0] Sorted by Name first name A-Z \n    [1] Sorted by last Name A-Z");
            Console.WriteLine("Edit \n   [3] Add entry \n   [4] remove entry");
            Console.WriteLine("Or \n   [5] Close Phone Book ");
            Console.WriteLine("Please enter the number in the [] next your choice");
            string choice = Console.ReadLine();

            // call action dependetion on users choice
            switch (choice)
            {
                case "0":
                    // Call Ethans Method
                    break;
                case "2":
                    //Call Dessa's method
                    break;
                case "3":
                    // code call Tommys Method
                    break;
                case "4":
                    // code call Jaysons Method
                    break;
                case "5":
                    break;

                default://  If they don't choose from one of the given options correctly remind them too and call the MainMenu Function Again
                    Console.Clear();
                    Console.WriteLine("ENTER THE NUMBER FROM THESE OPTIONS");
                    MainMenu();
                    break;
            }

        }
    }
}
