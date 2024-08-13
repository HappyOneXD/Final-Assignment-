namespace Assignment_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            btCalculate = new Button();
            btExit = new Button();
            btDelete = new Button();
            btEdit = new Button();
            btAdd = new Button();
            tbFinal = new TextBox();
            tbBill = new TextBox();
            tbConsum = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cbType = new ComboBox();
            tbThismonth = new TextBox();
            tbLastmonth = new TextBox();
            tbPhone = new TextBox();
            tbName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lwCustomer = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btCalculate);
            groupBox1.Controls.Add(btExit);
            groupBox1.Controls.Add(btDelete);
            groupBox1.Controls.Add(btEdit);
            groupBox1.Controls.Add(btAdd);
            groupBox1.Controls.Add(tbFinal);
            groupBox1.Controls.Add(tbBill);
            groupBox1.Controls.Add(tbConsum);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbType);
            groupBox1.Controls.Add(tbThismonth);
            groupBox1.Controls.Add(tbLastmonth);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 335);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(866, 201);
            label11.Name = "label11";
            label11.Size = new Size(56, 23);
            label11.TabIndex = 24;
            label11.Text = "(VND)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(866, 160);
            label10.Name = "label10";
            label10.Size = new Size(56, 23);
            label10.TabIndex = 23;
            label10.Text = "(VND)";
            label10.Click += label10_Click;
            // 
            // btCalculate
            // 
            btCalculate.Location = new Point(769, 285);
            btCalculate.Name = "btCalculate";
            btCalculate.Size = new Size(94, 29);
            btCalculate.TabIndex = 22;
            btCalculate.Text = "Calculate";
            btCalculate.UseVisualStyleBackColor = true;
            btCalculate.Click += btCalculate_Click_1;
            // 
            // btExit
            // 
            btExit.Location = new Point(621, 285);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 29);
            btExit.TabIndex = 21;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click_1;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(473, 285);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 20;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click_1;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(325, 285);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 29);
            btEdit.TabIndex = 19;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click_1;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(177, 285);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 18;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click_1;
            // 
            // tbFinal
            // 
            tbFinal.Location = new Point(674, 198);
            tbFinal.Name = "tbFinal";
            tbFinal.ReadOnly = true;
            tbFinal.Size = new Size(186, 30);
            tbFinal.TabIndex = 17;
            // 
            // tbBill
            // 
            tbBill.Location = new Point(674, 157);
            tbBill.Name = "tbBill";
            tbBill.ReadOnly = true;
            tbBill.Size = new Size(186, 30);
            tbBill.TabIndex = 16;
            // 
            // tbConsum
            // 
            tbConsum.Location = new Point(674, 116);
            tbConsum.Name = "tbConsum";
            tbConsum.ReadOnly = true;
            tbConsum.Size = new Size(186, 30);
            tbConsum.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(512, 201);
            label9.Name = "label9";
            label9.Size = new Size(72, 23);
            label9.TabIndex = 14;
            label9.Text = "Final bill";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 160);
            label8.Name = "label8";
            label8.Size = new Size(32, 23);
            label8.TabIndex = 13;
            label8.Text = "Bill";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(512, 119);
            label7.Name = "label7";
            label7.Size = new Size(113, 23);
            label7.TabIndex = 12;
            label7.Text = "Consumption";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Household", "Administrative agency", "Production units", "Business services" });
            cbType.Location = new Point(281, 157);
            cbType.Name = "cbType";
            cbType.Size = new Size(186, 31);
            cbType.TabIndex = 11;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // tbThismonth
            // 
            tbThismonth.Location = new Point(281, 239);
            tbThismonth.Name = "tbThismonth";
            tbThismonth.Size = new Size(186, 30);
            tbThismonth.TabIndex = 10;
            tbThismonth.TextChanged += tbThismonth_TextChanged;
            // 
            // tbLastmonth
            // 
            tbLastmonth.Location = new Point(281, 198);
            tbLastmonth.Name = "tbLastmonth";
            tbLastmonth.Size = new Size(186, 30);
            tbLastmonth.TabIndex = 9;
            tbLastmonth.TextChanged += tbLastmonth_TextChanged;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(281, 116);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(186, 30);
            tbPhone.TabIndex = 7;
            tbPhone.TextChanged += tbNumber_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(281, 75);
            tbName.Name = "tbName";
            tbName.Size = new Size(186, 30);
            tbName.TabIndex = 6;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 239);
            label6.Name = "label6";
            label6.Size = new Size(159, 23);
            label6.TabIndex = 5;
            label6.Text = "This month reading";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 198);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 4;
            label5.Text = "Last month's reading";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 157);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 3;
            label4.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 116);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 2;
            label3.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 75);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(454, 23);
            label1.Name = "label1";
            label1.Size = new Size(344, 38);
            label1.TabIndex = 0;
            label1.Text = "Water calculation program";
            label1.Click += label1_Click;
            // 
            // lwCustomer
            // 
            lwCustomer.Location = new Point(12, 365);
            lwCustomer.Name = "lwCustomer";
            lwCustomer.Size = new Size(959, 147);
            lwCustomer.TabIndex = 1;
            lwCustomer.UseCompatibleStateImageBehavior = false;
            lwCustomer.SelectedIndexChanged += lwCustomer_SelectedIndexChanged_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(983, 524);
            Controls.Add(lwCustomer);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lwCustomer;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbType;
        private TextBox tbThismonth;
        private TextBox tbLastmonth;
        private TextBox tbPhone;
        private TextBox tbName;
        private TextBox tbFinal;
        private TextBox tbBill;
        private TextBox tbConsum;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btCalculate;
        private Button btExit;
        private Button btDelete;
        private Button btEdit;
        private Button btAdd;
        private Label label10;
        private Label label11;
    }
}