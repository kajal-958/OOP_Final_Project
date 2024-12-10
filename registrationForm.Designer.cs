namespace FinancialTracker
{
    partial class registrationForm
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
            label1 = new Label();
            pictureBox = new PictureBox();
            btnRegister = new Button();
            txtRegisterEmail = new TextBox();
            txtRegisterPassword = new TextBox();
            txtRegisterUserName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblSignUp = new Label();
            panel1 = new Panel();
            btnSignIn = new Button();
            label2 = new Label();
            lblCross = new Label();
            chkShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // btnRegister
            // 
            btnRegister.BackColor = Color.Brown;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(561, 416);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(101, 40);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.BackColor = SystemColors.AppWorkspace;
            txtRegisterEmail.Location = new Point(446, 257);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(340, 27);
            txtRegisterEmail.TabIndex = 17;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.BackColor = SystemColors.AppWorkspace;
            txtRegisterPassword.Location = new Point(448, 334);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(340, 27);
            txtRegisterPassword.TabIndex = 16;
            // 
            // txtRegisterUserName
            // 
            txtRegisterUserName.BackColor = SystemColors.AppWorkspace;
            txtRegisterUserName.Location = new Point(446, 171);
            txtRegisterUserName.Name = "txtRegisterUserName";
            txtRegisterUserName.Size = new Size(340, 27);
            txtRegisterUserName.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(446, 220);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 14;
            label5.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(446, 299);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 13;
            label4.Text = "Password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(446, 148);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 12;
            label3.Text = "UserName: ";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.Location = new Point(544, 71);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(146, 36);
            lblSignUp.TabIndex = 11;
            lblSignUp.Text = "SIGN UP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 504);
            panel1.TabIndex = 10;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Brown;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderColor = Color.White;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(54, 430);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(287, 29);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "SIGN IN ";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(150, 391);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 2;
            label2.Text = "Sign In Here";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCross
            // 
            lblCross.AutoSize = true;
            lblCross.Cursor = Cursors.Hand;
            lblCross.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCross.Location = new Point(770, 9);
            lblCross.Name = "lblCross";
            lblCross.Size = new Size(18, 18);
            lblCross.TabIndex = 19;
            lblCross.Text = "X";
            lblCross.Click += lblCross_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(652, 367);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(136, 38);
            chkShowPassword.TabIndex = 20;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // registrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(chkShowPassword);
            Controls.Add(lblCross);
            Controls.Add(btnRegister);
            Controls.Add(txtRegisterEmail);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegisterUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSignUp);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registrationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox;
        private Button btnRegister;
        private TextBox txtRegisterEmail;
        private TextBox txtRegisterPassword;
        private TextBox txtRegisterUserName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblSignUp;
        private Panel panel1;
        private Button btnSignIn;
        private Label label2;
        private Label lblCross;
        private CheckBox chkShowPassword;
    }
}