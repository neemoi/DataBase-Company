
namespace Curs_MSU_PKL_17_2022
{
    partial class LogIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5RegisterUserLink = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_Click = new System.Windows.Forms.Label();
            this.ExitProgram = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordUser = new System.Windows.Forms.TextBox();
            this.textBoxLoginUser = new System.Windows.Forms.TextBox();
            this.buttonLogUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label5RegisterUserLink);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPasswordUser);
            this.panel1.Controls.Add(this.textBoxLoginUser);
            this.panel1.Controls.Add(this.buttonLogUser);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 454);
            this.panel1.TabIndex = 0;
            // 
            // label5RegisterUserLink
            // 
            this.label5RegisterUserLink.AutoSize = true;
            this.label5RegisterUserLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5RegisterUserLink.Location = new System.Drawing.Point(276, 385);
            this.label5RegisterUserLink.Name = "label5RegisterUserLink";
            this.label5RegisterUserLink.Size = new System.Drawing.Size(96, 20);
            this.label5RegisterUserLink.TabIndex = 7;
            this.label5RegisterUserLink.Text = "Регистрация";
            this.label5RegisterUserLink.Click += new System.EventHandler(this.label5RegisterUserLink_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.Close_Click);
            this.panel2.Controls.Add(this.ExitProgram);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 104);
            this.panel2.TabIndex = 6;
            // 
            // Close_Click
            // 
            this.Close_Click.AutoSize = true;
            this.Close_Click.Location = new System.Drawing.Point(485, 9);
            this.Close_Click.Name = "Close_Click";
            this.Close_Click.Size = new System.Drawing.Size(16, 20);
            this.Close_Click.TabIndex = 5;
            this.Close_Click.Text = "x";
            this.Close_Click.Click += new System.EventHandler(this.Close_Click_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.AutoSize = true;
            this.ExitProgram.Location = new System.Drawing.Point(611, 9);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(16, 20);
            this.ExitProgram.TabIndex = 4;
            this.ExitProgram.Text = "x";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSU-PKL-17-2022";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // textBoxPasswordUser
            // 
            this.textBoxPasswordUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.textBoxPasswordUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPasswordUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPasswordUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxPasswordUser.Location = new System.Drawing.Point(153, 256);
            this.textBoxPasswordUser.Multiline = true;
            this.textBoxPasswordUser.Name = "textBoxPasswordUser";
            this.textBoxPasswordUser.Size = new System.Drawing.Size(219, 40);
            this.textBoxPasswordUser.TabIndex = 2;
            this.textBoxPasswordUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPasswordUser.TextChanged += new System.EventHandler(this.textBoxPasswordUser_TextChanged);
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.textBoxLoginUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxLoginUser.Location = new System.Drawing.Point(153, 180);
            this.textBoxLoginUser.Multiline = true;
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.Size = new System.Drawing.Size(219, 40);
            this.textBoxLoginUser.TabIndex = 2;
            this.textBoxLoginUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogUser
            // 
            this.buttonLogUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLogUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(165)))), ((int)(((byte)(80)))));
            this.buttonLogUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogUser.Location = new System.Drawing.Point(153, 330);
            this.buttonLogUser.Name = "buttonLogUser";
            this.buttonLogUser.Size = new System.Drawing.Size(219, 42);
            this.buttonLogUser.TabIndex = 1;
            this.buttonLogUser.Text = "Войти";
            this.buttonLogUser.UseVisualStyleBackColor = true;
            this.buttonLogUser.Click += new System.EventHandler(this.buttonLogUser_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 454);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLoginUser;
        private System.Windows.Forms.Button buttonLogUser;
        private System.Windows.Forms.TextBox textBoxPasswordUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close_Click;
        private System.Windows.Forms.Label label5RegisterUserLink;
    }
}

