using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbLastmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbThismonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //Receive customer's information
            string name = tbName.Text;
            string type = null;
            string phone = tbPhone.Text;
            if (cbType.SelectedIndex == 0)
            {
                type = "Household";
            }
            else if (cbType.SelectedIndex == 1)
            {
                type = "Admin";
            }
            else if (cbType.SelectedIndex == 2)
            {
                type = "Production";
            }
            else if (cbType.SelectedIndex == 3)
            {
                type = "Business";
            }
            double LMR = default;

            double TMR = default;
            //check last month
            if (String.IsNullOrEmpty(tbLastmonth.Text))
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LMR = double.Parse(tbLastmonth.Text);
            }

            //check This month
            if (String.IsNullOrEmpty(tbThismonth.Text))
            {
                MessageBox.Show("Enter this month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TMR = double.Parse(tbThismonth.Text);
            }

            //get consumption
            double consumption = default;
            if (consumption < 0)
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                consumption = TMR - LMR;
            }
            double bill;
            bill = double.Parse(tbBill.Text);

            double totalBill;
            totalBill = double.Parse(tbBill.Text);
            ListViewItem cs_1 = new ListViewItem();

            //gán giấ trị đã lấy được trong form điền vào đối tượng cs_1
            cs_1.Text = name;
            cs_1.SubItems.Add(phone);
            cs_1.SubItems.Add(type);
            cs_1.SubItems.Add(LMR.ToString());
            cs_1.SubItems.Add(TMR.ToString());
            cs_1.SubItems.Add(consumption.ToString());
            cs_1.SubItems.Add(bill.ToString());
            cs_1.SubItems.Add(totalBill.ToString());

            //đẩy std vào lwCustomer
            lwCustomer.Items.Add(cs_1);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            ListViewItem item = lwCustomer.SelectedItems[0];
            item.SubItems.Clear();

            //Receive customer's information
            string name = tbName.Text;
            string type = null;
            string phone = tbPhone.Text;
            if (cbType.SelectedIndex == 0)
            {
                type = "Household";
            }
            else if (cbType.SelectedIndex == 1)
            {
                type = "Admin";
            }
            else if (cbType.SelectedIndex == 2)
            {
                type = "Production";
            }
            else if (cbType.SelectedIndex == 3)
            {
                type = "Business";
            }
            double LMR = default;

            double TMR = default;
            //check last month
            if (String.IsNullOrEmpty(tbLastmonth.Text))
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LMR = double.Parse(tbLastmonth.Text);
            }

            //check This month
            if (String.IsNullOrEmpty(tbThismonth.Text))
            {
                MessageBox.Show("Enter this month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TMR = double.Parse(tbThismonth.Text);
            }

            //get consumption
            double consumption = default;
            if (consumption < 0)
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                consumption = TMR - LMR;
            }
            double bill;
            bill = double.Parse(tbBill.Text);

            double totalBill;
            totalBill = double.Parse(tbFinal.Text);
            ListViewItem cs_1 = new ListViewItem();

            item.Text = name;
            item.SubItems.Add(phone);
            item.SubItems.Add(type);
            item.SubItems.Add(LMR.ToString());
            item.SubItems.Add(TMR.ToString());
            item.SubItems.Add(consumption.ToString());
            item.SubItems.Add(bill.ToString());
            item.SubItems.Add(totalBill.ToString());
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lwCustomer.SelectedItems.Count < 0)
            {
                MessageBox.Show("Select something to delete", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lwCustomer.Items.Remove(lwCustomer.SelectedItems[0]);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Leaving?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == -1)
            {
                MessageBox.Show("Select your type of customer", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //get info
            string name = tbName.Text;
            double LMR = double.Parse(tbLastmonth.Text);
            double TMR = double.Parse(tbThismonth.Text);

            double consumption = TMR - LMR;
            if (consumption < 0)
            {
                MessageBox.Show("Invalid", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //show the consumption
            tbConsum.Text = consumption.ToString();

            //get type
            string type = cbType.SelectedItem.ToString();
            double price = 0;

            //calculation Household /Administrative agency /Production units /Business services
            switch (type)
            {
                case "Household": // Household
                    if (consumption > 0 && consumption <= 10)
                    {
                        price = consumption * 5.973;
                    }
                    else if (consumption > 10 && consumption <= 20)
                    {
                        price = (10 * 5.973) + (consumption - 10) * 7.052;
                    }
                    else if (consumption > 20 && consumption <= 30)
                    {
                        price = (10 * 5.973) + (10 * 7.052) + (consumption - 20) * 8.699;
                    }
                    else
                    {
                        price = (10 * 5.973) + (10 * 7.052) + (10 * 8.699) + (consumption - 30) * 15.929;
                    }
                    break;

                case "Administrative agency":
                    price = consumption * 9.955;
                    break;

                case "Production units":
                    price = consumption * 11.615;
                    break;

                case "Business services":
                    price = consumption * 22.068;
                    break;
            }

            //show price
            tbBill.Text = price.ToString();

            //calculate Final billz
            double envFee = price * 0.10;
            double VAT = (price + envFee) * 0.1;
            double totalBill = price + envFee + VAT;
            tbFinal.Text = totalBill.ToString();


        }

        private void lwCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwCustomer.SelectedItems.Count > 0)
            {
                ListViewItem selected_Item = lwCustomer.SelectedItems[0];
                string name = selected_Item.SubItems[0].Text;
                string phone = selected_Item.SubItems[1].Text;
                string type = selected_Item.SubItems[2].Text;
                string LMR = selected_Item.SubItems[3].Text;
                string TMR = selected_Item.SubItems[4].Text;
                string consumption = selected_Item.SubItems[5].Text;

                //day du lieu len Household /Administrative agency /Production units /Business services
                tbName.Text = name;
                tbPhone.Text = phone;

                if (type == "Household")
                {
                    cbType.SelectedIndex = 0;
                }
                else if (type == "Administrative agency")
                {
                    cbType.SelectedIndex = 1;
                }
                else if (type == "Production units")
                {
                    cbType.SelectedIndex = 2;
                }
                else if (type == "Business services")
                {
                    cbType.SelectedIndex = 3;
                }

                tbLastmonth.Text = LMR;
                tbThismonth.Text = TMR;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Đổi chế độ view để hiển thị dữ liệu trên lw
            lwCustomer.View = View.Details;
            lwCustomer.GridLines = true;
            lwCustomer.FullRowSelect = true;

            //tạo cột cho lw
            lwCustomer.Columns.Add("Name", 150);
            lwCustomer.Columns.Add("Phone", 100);
            lwCustomer.Columns.Add("Type of customer", 100);
            lwCustomer.Columns.Add("Last month reading", 150);
            lwCustomer.Columns.Add("This month reading", 150);
            lwCustomer.Columns.Add("Water used", 100);
            lwCustomer.Columns.Add("Price", 100);
            lwCustomer.Columns.Add("Final bill (with tax)", 150);
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            //Receive customer's information
            string name = tbName.Text;
            string type = null;
            string phone = tbPhone.Text;
            if (cbType.SelectedIndex == 0)
            {
                type = "Household";
            }
            else if (cbType.SelectedIndex == 1)
            {
                type = "Admin";
            }
            else if (cbType.SelectedIndex == 2)
            {
                type = "Production";
            }
            else if (cbType.SelectedIndex == 3)
            {
                type = "Business";
            }
            double LMR = default;

            double TMR = default;
            //check last month
            if (String.IsNullOrEmpty(tbLastmonth.Text))
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LMR = double.Parse(tbLastmonth.Text);
            }

            //check This month
            if (String.IsNullOrEmpty(tbThismonth.Text))
            {
                MessageBox.Show("Enter this month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TMR = double.Parse(tbThismonth.Text);
            }

            //get consumption
            double consumption = default;
            if (consumption < 0)
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                consumption = TMR - LMR;
            }
            double bill;
            bill = double.Parse(tbBill.Text);

            double totalBill;
            totalBill = double.Parse(tbBill.Text);
            ListViewItem cs_1 = new ListViewItem();

            //gán giấ trị đã lấy được trong form điền vào đối tượng cs_1
            cs_1.Text = name;
            cs_1.SubItems.Add(phone);
            cs_1.SubItems.Add(type);
            cs_1.SubItems.Add(LMR.ToString());
            cs_1.SubItems.Add(TMR.ToString());
            cs_1.SubItems.Add(consumption.ToString());
            cs_1.SubItems.Add(bill.ToString());
            cs_1.SubItems.Add(totalBill.ToString());

            //đẩy std vào lwCustomer
            lwCustomer.Items.Add(cs_1);
        }

        private void btEdit_Click_1(object sender, EventArgs e)
        {
            ListViewItem item = lwCustomer.SelectedItems[0];
            item.SubItems.Clear();

            //Receive customer's information
            string name = tbName.Text;
            string type = null;
            string phone = tbPhone.Text;
            if (cbType.SelectedIndex == 0)
            {
                type = "Household";
            }
            else if (cbType.SelectedIndex == 1)
            {
                type = "Admin";
            }
            else if (cbType.SelectedIndex == 2)
            {
                type = "Production";
            }
            else if (cbType.SelectedIndex == 3)
            {
                type = "Business";
            }
            double LMR = default;

            double TMR = default;
            //check last month
            if (String.IsNullOrEmpty(tbLastmonth.Text))
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LMR = double.Parse(tbLastmonth.Text);
            }

            //check This month
            if (String.IsNullOrEmpty(tbThismonth.Text))
            {
                MessageBox.Show("Enter this month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TMR = double.Parse(tbThismonth.Text);
            }

            //get consumption
            double consumption = default;
            if (consumption < 0)
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                consumption = TMR - LMR;
            }
            double bill;
            bill = double.Parse(tbBill.Text);

            double totalBill;
            totalBill = double.Parse(tbFinal.Text);
            ListViewItem cs_1 = new ListViewItem();

            item.Text = name;
            item.SubItems.Add(phone);
            item.SubItems.Add(type);
            item.SubItems.Add(LMR.ToString());
            item.SubItems.Add(TMR.ToString());
            item.SubItems.Add(consumption.ToString());
            item.SubItems.Add(bill.ToString());
            item.SubItems.Add(totalBill.ToString());
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            if (lwCustomer.SelectedItems.Count < 0)
            {
                MessageBox.Show("Select something to delete", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lwCustomer.Items.Remove(lwCustomer.SelectedItems[0]);
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Leaving?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btCalculate_Click_1(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == -1)
            {
                MessageBox.Show("Select your type of customer", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //get info
            string name = tbName.Text;
            double LMR = double.Parse(tbLastmonth.Text);
            double TMR = double.Parse(tbThismonth.Text);

            //check last month
            if (String.IsNullOrEmpty(tbLastmonth.Text))
            {
                MessageBox.Show("Enter last month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LMR = double.Parse(tbLastmonth.Text);
            }

            //check This month
            if (String.IsNullOrEmpty(tbThismonth.Text))
            {
                MessageBox.Show("Enter this month reading properly", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TMR = double.Parse(tbThismonth.Text);
            }

            double consumption = TMR - LMR;
            if (consumption < 0)
            {
                MessageBox.Show("Invalid", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    

            //show the consumption
            tbConsum.Text = consumption.ToString();

            //get type
            string type = cbType.SelectedItem.ToString();
            double price = 0;

            //calculation Household /Administrative agency /Production units /Business services
            switch (type)
            {
                case "Household": // Household
                    if (consumption > 0 && consumption <= 10)
                    {
                        price = consumption * 5.973;
                    }
                    else if (consumption > 10 && consumption <= 20)
                    {
                        price = (10 * 5.973) + (consumption - 10) * 7.052;
                    }
                    else if (consumption > 20 && consumption <= 30)
                    {
                        price = (10 * 5.973) + (10 * 7.052) + (consumption - 20) * 8.699;
                    }
                    else
                    {
                        price = (10 * 5.973) + (10 * 7.052) + (10 * 8.699) + (consumption - 30) * 15.929;
                    }
                    break;

                case "Administrative agency":
                    price = consumption * 9.955;
                    break;

                case "Production units":
                    price = consumption * 11.615;
                    break;

                case "Business services":
                    price = consumption * 22.068;
                    break;
            }

            //show price
            tbBill.Text = price.ToString();

            //calculate Final billz
            double envFee = price * 0.10;
            double VAT = (price + envFee) * 0.1;
            double totalBill = price + envFee + VAT;
            tbFinal.Text = totalBill.ToString();

        }

        private void lwCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lwCustomer.SelectedItems.Count > 0)
            {
                ListViewItem selected_Item = lwCustomer.SelectedItems[0];
                string name = selected_Item.SubItems[0].Text;
                string phone = selected_Item.SubItems[1].Text;
                string type = selected_Item.SubItems[2].Text;
                string LMR = selected_Item.SubItems[3].Text;
                string TMR = selected_Item.SubItems[4].Text;
                string consumption = selected_Item.SubItems[5].Text;

                //day du lieu len Household /Administrative agency /Production units /Business services
                tbName.Text = name;
                tbPhone.Text = phone;

                if (type == "Household")
                {
                    cbType.SelectedIndex = 0;
                }
                else if (type == "Administrative agency")
                {
                    cbType.SelectedIndex = 1;
                }
                else if (type == "Production units")
                {
                    cbType.SelectedIndex = 2;
                }
                else if (type == "Business services")
                {
                    cbType.SelectedIndex = 3;
                }

                tbLastmonth.Text = LMR;
                tbThismonth.Text = TMR;
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            //Đổi chế độ view để hiển thị dữ liệu trên lw
            lwCustomer.View = View.Details;
            lwCustomer.GridLines = true;
            lwCustomer.FullRowSelect = true;

            //tạo cột cho lw
            lwCustomer.Columns.Add("Name", 150);
            lwCustomer.Columns.Add("Phone", 100);
            lwCustomer.Columns.Add("Type of customer", 100);
            lwCustomer.Columns.Add("Last month reading", 150);
            lwCustomer.Columns.Add("This month reading", 150);
            lwCustomer.Columns.Add("Water used", 100);
            lwCustomer.Columns.Add("Price", 100);
            lwCustomer.Columns.Add("Final bill (with tax)", 150);
        }
    }
}
