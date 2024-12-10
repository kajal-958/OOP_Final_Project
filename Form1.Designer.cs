namespace FinancialTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox = new PictureBox();
            lblCross = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 504);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 201);
            label1.Name = "label1";
            label1.Size = new Size(213, 26);
            label1.TabIndex = 1;
            label1.Text = "Financial Tracker";
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.user1;
            pictureBox.Location = new Point(153, 84);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(99, 101);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lblCross
            // 
            lblCross.AutoSize = true;
            lblCross.Cursor = Cursors.Hand;
            lblCross.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCross.Location = new Point(770, 9);
            lblCross.Name = "lblCross";
            lblCross.Size = new Size(18, 18);
            lblCross.TabIndex = 1;
            lblCross.Text = "X";
            lblCross.Click += lblCross_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(530, 71);
            label2.Name = "label2";
            label2.Size = new Size(138, 36);
            label2.TabIndex = 2;
            label2.Text = "SIGN IN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(432, 148);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "UserName: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(432, 220);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Password: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(432, 301);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 5;
            label5.Text = "Email: ";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.AppWorkspace;
            txtUserName.Location = new Point(432, 171);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(330, 27);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.AppWorkspace;
            txtPassword.Location = new Point(432, 253);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.AppWorkspace;
            txtEmail.Location = new Point(432, 334);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 27);
            txtEmail.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Brown;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(552, 397);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 40);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 504);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCross);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblCross;
        private PictureBox pictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogin;
    }
}
