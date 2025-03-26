using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentWinForms
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnLogin = new Button();
            lblChoose = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(268, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(268, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 27);
            txtPassword.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(301, 65);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(178, 28);
            cmbRole.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(301, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(178, 83);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Enter";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Location = new Point(365, 42);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(58, 20);
            lblChoose.TabIndex = 4;
            lblChoose.Text = "Choose";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(353, 112);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "UserName";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(353, 182);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(268, 281);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 27);
            txtName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 258);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblChoose);
            Controls.Add(btnLogin);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private Button btnLogin;
        private Label lblChoose;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtName;
        private Label label1;
    }
}