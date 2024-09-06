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

        internal static void SaveContact(Contact contact)
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
    }
}
