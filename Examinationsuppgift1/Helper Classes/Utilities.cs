using System.Text.Json;

namespace Examinationsuppgift1
{
    public static class Utilities
    {
        const string filePath = @"C:\dev\Skola\CsharpKurs1\DbFiles\adressbok.txt";

        static string contactInDbAsString = string.Empty;

        public static void SaveContact(Contact contact)
        {
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

        public static List<Contact> LoadContacts()
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

        public static bool IsJsonStringInFile(string input)
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

        public static void OverwriteContactStringInFile(string input)
        {
            string fileContent = File.ReadAllText(filePath);
            fileContent = fileContent.Replace(contactInDbAsString, input);
            File.WriteAllText(filePath, fileContent);
        }

        public static void DeleteContact(string input)
        {
            List<string> jsonStringLines = File.ReadAllLines(filePath).ToList();
            jsonStringLines.RemoveAll(line => line.Equals(input));
            File.WriteAllLines(filePath, jsonStringLines);

        }

        public static string[] SearchInputToArray(string searchInput)
        {
            string[] searchInputArray = searchInput.Split(' ');

            return searchInputArray;
        }

        public static List<Contact> SearchMethod(string[] searchInput, List<Contact> a)
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