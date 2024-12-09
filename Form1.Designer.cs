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
            panel1.Size = new Size(413, 450);
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
            lblCross.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCross.Location = new Point(770, 9);
            lblCross.Name = "lblCross";
            lblCross.Size = new Size(18, 18);
            lblCross.TabIndex = 1;
            lblCross.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
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
    }
}
