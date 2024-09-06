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
                Contact contact = new Contact(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtAddress.Text.Trim(), txtPostalCode.Text.Trim().Replace(" ",""), txtCity.Text.Trim(), txtPhoneNumber.Text.Trim(), txtEmail.Text.Trim());
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

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string searchInput = txtSearchField.Text;
            List<Contact> contacts = Utilities.LoadContacts();

            List<Contact> returnList= contacts.Where(contact => string.Equals(contact.FirstName, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.LastName, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.Address, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.PostalCode, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.City, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.PhoneNumber, searchInput, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(contact.Email, searchInput, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (Contact contact in returnList)
            {
                lstSearchResult.Items.Add(contact.ToString());
            }
        }
    }
}
