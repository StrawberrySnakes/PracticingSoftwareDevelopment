using System.Linq.Expressions;
namespace Practicing_Software_Development
{
    internal class Program
    {
        // pre-made Dictionary phoneBook with 3 entries Ethan with a Small upodate by Jayson
       static Dictionary<string, string> phoneBook = new Dictionary<string, string>
        {
            {"Alvin", "555-1233"}, {"Brittany", "555-4567"}, {"Simon", "555-8910"}
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Phone Book");
            MainMenu();
        }
        // Jayson
        // Write out to the console the Menu Menu and handle the selected option
        static void MainMenu()
        {
            // write out menu
            Console.WriteLine("View PhoneBook \n    [0] Sorted by Name first name A-Z \n    [1] Search");
            Console.WriteLine("Edit \n   [3] Add entry \n   [4] remove entry");
            Console.WriteLine("Or \n   [5] Close Phone Book ");
            Console.WriteLine("Please enter the number in the [] next your choice");
            string choice = Console.ReadLine();

            // call action dependetion on users choice
            switch (choice)
            {
                case "0":
                    // Call Ethans Method
                    DisplaySorted();
                    break;
                case "1":
                    //Call Dessa's method
                    SearchEntry();
                    break;
                case "3":
                    AddEntry();
                    break;
                case "4":
                    // code call Jaysons Method
                    RemoveEntry();
                    break;
                case "5":
                    Console.WriteLine("Closing the phonebook, bye!");
                    return;

                default://  If they don't choose from one of the given options correctly remind them too and call the MainMenu Function Again
                    Console.Clear();
                    Console.WriteLine("ENTER THE NUMBER FROM THESE OPTIONS");
                    MainMenu();
                    break;
            }

        }

        static void DisplaySorted()
        {
            Console.WriteLine("\nPhonebook sorted by name: ");
            // Sort dictionary alphabetically by keys
            var sortedPhoneBook = phoneBook.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (KeyValuePair<string, string> pair in sortedPhoneBook)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            MainMenu();
        }

        // Tommy
        // Function that adds new entries to the phonebook
        static void AddEntry()
        {
            Console.WriteLine("\nEnter the nane: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter the phone number: ");
            string phoneNumber = Console.ReadLine();
            if (!phoneBook.ContainsKey(name))
            {
                phoneBook.Add(name, phoneNumber);
            }
            else
            {
                Console.WriteLine("Name already exists in the phone book.");
            }
            MainMenu();
        }

        // Jayson's function that removes entries
        static void RemoveEntry()
        {
            Console.WriteLine("\nEnter the nane: ");
            string key = Console.ReadLine();
            if (!phoneBook.ContainsKey(key))
            {
                Console.WriteLine($"{key} doens't exixst in the phonebook");
            }
            else
            {
                phoneBook.Remove(key);
                Console.WriteLine($"{key} removed from phonebook");
            }
            MainMenu();
        }

        //Dessa's functions that seaches using name
        static void SearchEntry()
        {
            Console.WriteLine("\nEnter the nane: ");
            string keyToFind = Console.ReadLine();
            if (!phoneBook.ContainsKey(keyToFind))
            {
                Console.WriteLine($"{keyToFind} doens't exixst in the phonebook");
            }
            else
            {
                string number = phoneBook[keyToFind];
                Console.WriteLine($"\n{keyToFind}: {number}\n");
            }
            MainMenu();
        }
    }
}
