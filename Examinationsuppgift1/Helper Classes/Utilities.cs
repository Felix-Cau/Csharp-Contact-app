using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

                return contacts;
            }
        }

        internal static bool IsJsonStringInFile(string input)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    contactInDbAsString = reader.ReadLine();

                    bool doesContactExist = string.Equals(contactInDbAsString, input, StringComparison.OrdinalIgnoreCase);

                    //Med eller utan curly brackets?
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
            string fileContent = File.ReadAllText(filePath);
            fileContent = fileContent.Replace(input, string.Empty);
            File.WriteAllText(filePath, fileContent);
        }

        internal static string[] SearchInputToArray(string searchInput)
        {
            string[] searchInputArray = searchInput.Split(' ');

            return searchInputArray;
        }

        internal static List<string> SearchMethod(string[] searchInput, List<Contact> loadedList)
        {
            List<Contact> returnList = new();
            
            for (int i = 0; i < searchInput.Length; i++)
            {
                if (string.Equals(contact => loadedList.Name, searchInput, StringComparison.OrdinalIgnoreCase) ||
                                                        string.Equals(contact.Address, searchInput, StringComparison.OrdinalIgnoreCase) ||
                                                        string.Equals(contact.PostalCode, searchInput, StringComparison.OrdinalIgnoreCase) ||
                                                        string.Equals(contact.City, searchInput, StringComparison.OrdinalIgnoreCase) ||
                                                        string.Equals(contact.PhoneNumber, searchInput, StringComparison.OrdinalIgnoreCase) ||
                                                        string.Equals(contact.Email, searchInput, StringComparison.OrdinalIgnoreCase)).ToList());
            }
        }
    }
}