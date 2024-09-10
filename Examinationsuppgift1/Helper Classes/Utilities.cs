using System.Text.Json;

namespace Examinationsuppgift1
{
    internal static class Utilities
    {
        const string filePath = @"C:\dev\Skola\CsharpKurs1\DbFiles\adressbok.txt";

        static string contactInDbAsString = string.Empty;

        internal static void SaveContact(Contact contact)
        {
            //Lägga in try/catch?
            if (File.Exists(filePath))
            {
                string contactAsString = JsonSerializer.Serialize(contact);

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(contactAsString);
                }
            }
            else
            {
                string contactAsString = JsonSerializer.Serialize(contact);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(contactAsString);
                }
            }
        }

        internal static List<Contact> LoadContacts()
        {
            List<Contact> contacts = new();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string contactAsString = reader.ReadLine();

                        Contact contact = JsonSerializer.Deserialize<Contact>(contactAsString);

                        contacts.Add(contact);
                    }
                }

            return contacts;
        }

        internal static bool IsJsonStringInFile(string input)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    contactInDbAsString = reader.ReadLine();

                    bool doesContactExist = string.Equals(contactInDbAsString, input, StringComparison.OrdinalIgnoreCase);

                    if (doesContactExist)
                        return true;
                }

                return false;
            }
        }

        internal static void OverwriteContactStringInFile(string input)
        {
            string fileContent = File.ReadAllText(filePath);
            fileContent = fileContent.Replace(contactInDbAsString, input);
            File.WriteAllText(filePath, fileContent);
        }

        internal static void DeleteContact(string input)
        {
            //Läser in alla rader som strings i en lista av strings.
            List<string> jsonStringLines = File.ReadAllLines(filePath).ToList();
            //Tar bort den string som matchar den jag vill ta bort.
            jsonStringLines.RemoveAll(line => line.Equals(input));
            //Skriver tillbaka alla kvarvarande strängar till filen.
            File.WriteAllLines(filePath, jsonStringLines);

        }

        internal static string[] SearchInputToArray(string searchInput)
        {
            string[] searchInputArray = searchInput.Split(' ');

            return searchInputArray;
        }

        internal static List<Contact> SearchMethod(string[] searchInput, List<Contact> a)
        {
            List<Contact> loadedList = a;
            List<Contact> returnUnfilteredList = new();
            
            for (int i = 0; i < searchInput.Length; i++)
            {
                foreach (Contact contact in loadedList)
                {
                    if (contact.Name.Contains(searchInput[i], StringComparison.OrdinalIgnoreCase) ||
                        contact.Address.Contains(searchInput[i], StringComparison.OrdinalIgnoreCase) ||
                        contact.PostalCode.Contains(searchInput[i], StringComparison.OrdinalIgnoreCase) ||
                        contact.City.Contains(searchInput[i], StringComparison.OrdinalIgnoreCase) ||
                        contact.PhoneNumber.Contains(searchInput[i], StringComparison.OrdinalIgnoreCase) ||
                        contact.Email.Contains(searchInput[i], StringComparison.OrdinalIgnoreCase))
                    {
                        returnUnfilteredList.Add(contact);
                    }
                }
            }

            List<Contact> returnFilteredList = returnUnfilteredList.DistinctBy(contact => contact.Email).ToList();

            return returnFilteredList;
        }
    }
}