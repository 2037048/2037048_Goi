namespace _2037048_Goi
{
    partial class Form1
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
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrpLogin = new System.Windows.Forms.GroupBox();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPW = new System.Windows.Forms.Label();
            this.GrpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(6, 108);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(75, 23);
            this.BtnLogIn.TabIndex = 0;
            this.BtnLogIn.Text = "Log in";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(108, 108);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "button2";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GrpLogin
            // 
            this.GrpLogin.Controls.Add(this.LblPW);
            this.GrpLogin.Controls.Add(this.LblUser);
            this.GrpLogin.Controls.Add(this.TxtPW);
            this.GrpLogin.Controls.Add(this.TextUser);
            this.GrpLogin.Controls.Add(this.BtnLogIn);
            this.GrpLogin.Controls.Add(this.BtnCancel);
            this.GrpLogin.Location = new System.Drawing.Point(31, 22);
            this.GrpLogin.Name = "GrpLogin";
            this.GrpLogin.Size = new System.Drawing.Size(315, 147);
            this.GrpLogin.TabIndex = 2;
            this.GrpLogin.TabStop = false;
            this.GrpLogin.Text = "groupBox1";
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(191, 19);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(100, 20);
            this.TextUser.TabIndex = 2;
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(191, 62);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(100, 20);
            this.TxtPW.TabIndex = 3;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(44, 35);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(35, 13);
            this.LblUser.TabIndex = 4;
            this.LblUser.Text = "label1";
            // 
            // LblPW
            // 
            this.LblPW.AutoSize = true;
            this.LblPW.Location = new System.Drawing.Point(44, 65);
            this.LblPW.Name = "LblPW";
            this.LblPW.Size = new System.Drawing.Size(35, 13);
            this.LblPW.TabIndex = 5;
            this.LblPW.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.GrpLogin);
            this.Name = "Form1";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.TxtUser_Load);
            this.GrpLogin.ResumeLayout(false);
            this.GrpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GrpLogin;
        private System.Windows.Forms.Label LblPW;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TextUser;
    }
}

