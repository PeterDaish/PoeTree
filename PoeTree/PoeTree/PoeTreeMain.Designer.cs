namespace PoeTree
{
    partial class PoeTreeMain
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameConfirmButton = new System.Windows.Forms.Button();
            this.welcomeUserLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(329, 44);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(42, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "titleLBL";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(302, 130);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 20);
            this.usernameTxt.TabIndex = 1;
            // 
            // usernameConfirmButton
            // 
            this.usernameConfirmButton.Location = new System.Drawing.Point(312, 200);
            this.usernameConfirmButton.Name = "usernameConfirmButton";
            this.usernameConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.usernameConfirmButton.TabIndex = 2;
            this.usernameConfirmButton.Text = "Confirm";
            this.usernameConfirmButton.UseVisualStyleBackColor = true;
            this.usernameConfirmButton.Click += new System.EventHandler(this.usernameConfirmButton_Click);
            // 
            // welcomeUserLbl
            // 
            this.welcomeUserLbl.AutoSize = true;
            this.welcomeUserLbl.Location = new System.Drawing.Point(312, 279);
            this.welcomeUserLbl.Name = "welcomeUserLbl";
            this.welcomeUserLbl.Size = new System.Drawing.Size(85, 13);
            this.welcomeUserLbl.TabIndex = 3;
            this.welcomeUserLbl.Text = "welcomeUserLbl";
            // 
            // PoeTreeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeUserLbl);
            this.Controls.Add(this.usernameConfirmButton);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.titleLbl);
            this.Name = "PoeTreeMain";
            this.Text = "PoeTree";
            this.Load += new System.EventHandler(this.PoeTreeMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button usernameConfirmButton;
        private System.Windows.Forms.Label welcomeUserLbl;
    }
}

