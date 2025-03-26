namespace CarRentWinForms
{
    partial class UserForm
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
            btnRentcar = new Button();
            btnReturncar = new Button();
            btnShowAvailablecars = new Button();
            listBox1 = new ListBox();
            txtdays = new TextBox();
            txtplate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnback = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // btnRentcar
            // 
            btnRentcar.Location = new Point(31, 47);
            btnRentcar.Name = "btnRentcar";
            btnRentcar.Size = new Size(178, 93);
            btnRentcar.TabIndex = 0;
            btnRentcar.Text = "Rent Car";
            btnRentcar.UseVisualStyleBackColor = true;
            // 
            // btnReturncar
            // 
            btnReturncar.Location = new Point(291, 47);
            btnReturncar.Name = "btnReturncar";
            btnReturncar.Size = new Size(178, 93);
            btnReturncar.TabIndex = 1;
            btnReturncar.Text = "Return Car";
            btnReturncar.UseVisualStyleBackColor = true;
            // 
            // btnShowAvailablecars
            // 
            btnShowAvailablecars.Location = new Point(568, 47);
            btnShowAvailablecars.Name = "btnShowAvailablecars";
            btnShowAvailablecars.Size = new Size(178, 93);
            btnShowAvailablecars.TabIndex = 2;
            btnShowAvailablecars.Text = "Show Available Cars";
            btnShowAvailablecars.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(519, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 284);
            listBox1.TabIndex = 3;
            // 
            // txtdays
            // 
            txtdays.Location = new Point(31, 204);
            txtdays.Name = "txtdays";
            txtdays.Size = new Size(178, 27);
            txtdays.TabIndex = 4;
            // 
            // txtplate
            // 
            txtplate.Location = new Point(291, 204);
            txtplate.Name = "txtplate";
            txtplate.Size = new Size(178, 27);
            txtplate.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 176);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 6;
            label1.Text = "Days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 176);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 7;
            label2.Text = "Plate Number";
            // 
            // btnback
            // 
            btnback.Location = new Point(1, 3);
            btnback.Name = "btnback";
            btnback.Size = new Size(50, 38);
            btnback.TabIndex = 8;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(746, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(51, 38);
            btnexit.TabIndex = 9;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexit);
            Controls.Add(btnback);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtplate);
            Controls.Add(txtdays);
            Controls.Add(listBox1);
            Controls.Add(btnShowAvailablecars);
            Controls.Add(btnReturncar);
            Controls.Add(btnRentcar);
            Name = "UserForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRentcar;
        private Button btnReturncar;
        private Button btnShowAvailablecars;
        private ListBox listBox1;
        private TextBox txtdays;
        private TextBox txtplate;
        private Label label1;
        private Label label2;
        private Button btnback;
        private Button btnexit;
    }
}