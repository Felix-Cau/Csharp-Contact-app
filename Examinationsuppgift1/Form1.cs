using System.Text.Json;

namespace Examinationsuppgift1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSaveToDb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPostalCode.Text) ||
                string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Alla fält måste vara ifyllda.");
                return;
            }
            else
            {
                Contact contact = new Contact(txtName.Text.Trim(), txtAddress.Text.Trim(), txtPostalCode.Text.Trim().Replace(" ", ""),
                                                txtCity.Text.Trim(), txtPhoneNumber.Text.Trim().Replace(" ", ""), txtEmail.Text.Trim());

                string contactAsString = JsonSerializer.Serialize(contact);
                bool doesContactExist = Utilities.IsJsonStringInFile(contactAsString);

                if (!doesContactExist)
                {
                    Utilities.SaveContact(contact);
                    MessageBox.Show("Kontakten sparad.");
                    txtName.Clear();
                    txtAddress.Clear();
                    txtPostalCode.Clear();
                    txtCity.Clear();
                    txtPhoneNumber.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    Utilities.OverwriteContactStringInFile(contactAsString);
                    MessageBox.Show("Kontakten uppdaterad.");
                    txtName.Clear();
                    txtAddress.Clear();
                    txtPostalCode.Clear();
                    txtCity.Clear();
                    txtPhoneNumber.Clear();
                    txtEmail.Clear();
                }
            }
        }

        //Göra private readonly med constructor(om tid finns)
        List<Contact> loadedList = new();

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string searchInput = txtSearchField.Text.Trim();

            //Denna helpermetod går att skriva som en enstaka rad här egentligen. Är det dumt att bryta ut något som är så simpelt?
            string[] searchInputAsArray = Utilities.SearchInputToArray(searchInput);
            loadedList = Utilities.LoadContacts();

            List<Contact> returnList = Utilities.SearchMethod(searchInputAsArray, loadedList);

            lstSearchResult.DataSource = returnList;
        }

        private void lstSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact displayContact = (Contact)lstSearchResult.SelectedItem;

            txtName.Text = displayContact.Name;
            txtAddress.Text = displayContact.Address;
            txtPostalCode.Text = displayContact.PostalCode;
            txtCity.Text = displayContact.City;
            txtPhoneNumber.Text = displayContact.PhoneNumber;
            txtEmail.Text = displayContact.Email;
        }

        private void cmdResetSearch_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSearchField.Text = string.Empty;
        }
    }
}
