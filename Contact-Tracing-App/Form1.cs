namespace Contact_Tracing_App
{
    public partial class ContactTracingForm : Form
    {
        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsentCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SexLabel_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Nametextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void TimeInTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void ContactTracingForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void EmergencyNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmergencyAddressTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmergencyNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisitorInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeoutTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeoutLabel_Click(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            StreamWriter file = File.AppendText(@"C:\Users\rodfr\Downloads\ContactTracingform.txt");
            file.WriteLine("Visitor's Information");
            file.WriteLine("Name:" + Nametextbox.Text);
            file.WriteLine("Address:" + AddressTextBox.Text);
            file.WriteLine("Contact Number:" + ContactNumberTextbox.Text);
            file.WriteLine("Date:" + DateTextbox.Text);
            file.WriteLine("Time In:" + TimeInTextbox.Text);
            file.WriteLine("Time Out:" + TimeoutTextbox.Text);
            file.WriteLine("");            file.WriteLine("Emergency Contact's Information");
            file.WriteLine("Name" + EmergencyNameTextbox.Text);
            file.WriteLine("Contact Number" + EmergencyNumberTextbox.Text);
            file.WriteLine("Address" + EmergencyAddressTextbox.Text);
            file.WriteLine("");
            file.WriteLine("");
            file.Close();
        }
    }
}