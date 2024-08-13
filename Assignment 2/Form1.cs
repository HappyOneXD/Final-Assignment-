using System.Xml.Linq;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string pass = tbPass.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Username is wrong or empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbName.Focus();
            }
            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Password is wrong or empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPass.Focus();
            }
            else
            {
                if (name == "admin" && pass == "admin")
                {
                    Form2 MainForm = new Form2();
                    MainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
