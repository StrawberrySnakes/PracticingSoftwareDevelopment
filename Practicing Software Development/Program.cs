namespace Practicing_Software_Development
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ethan's part
            // This dictionary is just a temoporary one I use this one to make sure my method works
            //The dictionary NEEDS TO BE STRING
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
        {
            {"bob", "1231"},
            {"charlie", "1232"},
            {"alvin", "1233"}
        };


            // Sort dictionary alphabetically by keys
            var sortedPhoneBook = phoneBook.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (KeyValuePair<string, string> pair in sortedPhoneBook)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
