namespace CarRentWinForms
{
    partial class AdminForm
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
            btnAddcar = new Button();
            btnAddcustomer = new Button();
            btnDeletecar = new Button();
            btnCustomerhistory = new Button();
            listhistory = new ListBox();
            txtPlate = new TextBox();
            txtMark = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Cartype = new ComboBox();
            label7 = new Label();
            btnback = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // btnAddcar
            // 
            btnAddcar.Location = new Point(85, 12);
            btnAddcar.Name = "btnAddcar";
            btnAddcar.Size = new Size(131, 65);
            btnAddcar.TabIndex = 0;
            btnAddcar.Text = "Add Car";
            btnAddcar.UseVisualStyleBackColor = true;
            // 
            // btnAddcustomer
            // 
            btnAddcustomer.Location = new Point(12, 366);
            btnAddcustomer.Name = "btnAddcustomer";
            btnAddcustomer.Size = new Size(148, 65);
            btnAddcustomer.TabIndex = 1;
            btnAddcustomer.Text = "Add Customer";
            btnAddcustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeletecar
            // 
            btnDeletecar.Location = new Point(270, 12);
            btnDeletecar.Name = "btnDeletecar";
            btnDeletecar.Size = new Size(131, 65);
            btnDeletecar.TabIndex = 2;
            btnDeletecar.Text = "Delete Car";
            btnDeletecar.UseVisualStyleBackColor = true;
            // 
            // btnCustomerhistory
            // 
            btnCustomerhistory.Location = new Point(578, 12);
            btnCustomerhistory.Name = "btnCustomerhistory";
            btnCustomerhistory.Size = new Size(131, 65);
            btnCustomerhistory.TabIndex = 3;
            btnCustomerhistory.Text = "Show Customer History";
            btnCustomerhistory.UseVisualStyleBackColor = true;
            // 
            // listhistory
            // 
            listhistory.FormattingEnabled = true;
            listhistory.Location = new Point(486, 83);
            listhistory.Name = "listhistory";
            listhistory.Size = new Size(312, 364);
            listhistory.TabIndex = 4;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(39, 197);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(177, 27);
            txtPlate.TabIndex = 5;
            // 
            // txtMark
            // 
            txtMark.Location = new Point(39, 265);
            txtMark.Name = "txtMark";
            txtMark.Size = new Size(177, 27);
            txtMark.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(270, 197);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(177, 27);
            txtModel.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(270, 265);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(177, 27);
            txtYear.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(187, 358);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 27);
            txtName.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(187, 411);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(204, 27);
            txtPhone.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 165);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 11;
            label1.Text = "Plate Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 242);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 12;
            label2.Text = "Mark";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 165);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 13;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 242);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 14;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 334);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 15;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 388);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 16;
            label6.Text = "Phone Number";
            // 
            // Cartype
            // 
            Cartype.FormattingEnabled = true;
            Cartype.Location = new Point(158, 117);
            Cartype.Name = "Cartype";
            Cartype.Size = new Size(165, 28);
            Cartype.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 94);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 18;
            label7.Text = "Car Type";
            // 
            // btnback
            // 
            btnback.Location = new Point(-1, 1);
            btnback.Name = "btnback";
            btnback.Size = new Size(59, 29);
            btnback.TabIndex = 19;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(736, 1);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(62, 32);
            btnexit.TabIndex = 20;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexit);
            Controls.Add(btnback);
            Controls.Add(label7);
            Controls.Add(Cartype);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtMark);
            Controls.Add(txtPlate);
            Controls.Add(listhistory);
            Controls.Add(btnCustomerhistory);
            Controls.Add(btnDeletecar);
            Controls.Add(btnAddcustomer);
            Controls.Add(btnAddcar);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddcar;
        private Button btnAddcustomer;
        private Button btnDeletecar;
        private Button btnCustomerhistory;
        private ListBox listhistory;
        private TextBox txtPlate;
        private TextBox txtMark;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtName;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox Cartype;
        private Label label7;
        private Button btnback;
        private Button btnexit;
    }
}