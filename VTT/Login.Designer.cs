namespace VTT
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Server_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Create_acount = new System.Windows.Forms.Button();
            this.Local = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "User Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Password";
            // 
            // Server_Login
            // 
            this.Server_Login.Location = new System.Drawing.Point(118, 150);
            this.Server_Login.Name = "Server_Login";
            this.Server_Login.Size = new System.Drawing.Size(75, 23);
            this.Server_Login.TabIndex = 2;
            this.Server_Login.Text = "Login";
            this.Server_Login.UseVisualStyleBackColor = true;
            this.Server_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Login to use server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Create_acount
            // 
            this.Create_acount.Location = new System.Drawing.Point(45, 233);
            this.Create_acount.Name = "Create_acount";
            this.Create_acount.Size = new System.Drawing.Size(148, 82);
            this.Create_acount.TabIndex = 4;
            this.Create_acount.Text = "Create account";
            this.Create_acount.UseVisualStyleBackColor = true;
            // 
            // Local
            // 
            this.Local.Location = new System.Drawing.Point(209, 233);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(155, 82);
            this.Local.TabIndex = 5;
            this.Local.Text = "Local Game";
            this.Local.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 374);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.Create_acount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Server_Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Server_Login;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Create_acount;
        private System.Windows.Forms.Button Local;
    }
}

