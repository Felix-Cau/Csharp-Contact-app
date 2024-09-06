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
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPostalCode.Text) ||
                string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("All fields must be filled in");
                return;
            }
            else
            {
                Contact contact = new Contact(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtAddress.Text.Trim(), txtPostalCode.Text.Trim().Replace(" ", ""), txtCity.Text.Trim(), txtPhoneNumber.Text.Trim(), txtEmail.Text.Trim());
                Utilities.SaveContact(contact);
                MessageBox.Show("Contact saved to database");
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtPostalCode.Clear();
                txtCity.Clear();
                txtPhoneNumber.Clear();
                txtEmail.Clear();
            }

        }

        List<Contact> displayList = new();

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string searchInput = txtSearchField.Text;
            List<Contact> displayList = Utilities.LoadContacts();

            List<Contact> returnList = displayList.Where(contact => string.Equals(contact.FirstName, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.LastName, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.Address, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.PostalCode, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.City, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.PhoneNumber, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.Email, searchInput, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (Contact contact in returnList)
            {
                string firstName = contact.FirstName;
                string lastName = contact.LastName;
                string displayText = $"{firstName} {lastName}";
                lstSearchResult.Items.Add(displayText);
            }
        }

        private void lstSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inputContactName = lstSearchResult.SelectedItem.ToString();
            string[] separatedName = Utilities.SplitChosenName(inputContactName);
            (string firstName, string lastName) = (separatedName[0], separatedName[1]);

            Contact displayContact = displayList.FirstOrDefault(contact => string.Equals(contact.FirstName, firstName, StringComparison.OrdinalIgnoreCase) && 
                                                                string.Equals(contact.LastName, lastName, StringComparison.OrdinalIgnoreCase));

            txtFirstName.Text = displayContact.FirstName;
            txtLastName.Text = displayContact.LastName;
            txtAddress.Text = displayContact.Address;
            txtPostalCode.Text = displayContact.PostalCode;
            txtCity.Text = displayContact.City;
            txtPhoneNumber.Text = displayContact.PhoneNumber;
            txtEmail.Text = displayContact.Email;
        }
    }
}
