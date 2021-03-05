namespace PoeTree
{
    partial class HaikuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaikuForm));
            this.titleHaiku = new System.Windows.Forms.Label();
            this.linkLblHaikuDescription = new System.Windows.Forms.LinkLabel();
            this.txtBoxFirstPhrase = new System.Windows.Forms.TextBox();
            this.groupBoxPhraseOne = new System.Windows.Forms.GroupBox();
            this.groupBoxYourHaiku = new System.Windows.Forms.GroupBox();
            this.groupBoxSecondPhrase = new System.Windows.Forms.GroupBox();
            this.txtBoxSecondPhrase = new System.Windows.Forms.TextBox();
            this.groupBoxThirdPhrase = new System.Windows.Forms.GroupBox();
            this.txtBoxThirdPhrase = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBoxPhraseOne.SuspendLayout();
            this.groupBoxYourHaiku.SuspendLayout();
            this.groupBoxSecondPhrase.SuspendLayout();
            this.groupBoxThirdPhrase.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleHaiku
            // 
            this.titleHaiku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleHaiku.AutoSize = true;
            this.titleHaiku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleHaiku.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHaiku.Location = new System.Drawing.Point(12, 9);
            this.titleHaiku.Name = "titleHaiku";
            this.titleHaiku.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleHaiku.Size = new System.Drawing.Size(129, 48);
            this.titleHaiku.TabIndex = 0;
            this.titleHaiku.Text = "Haiku";
            // 
            // linkLblHaikuDescription
            // 
            this.linkLblHaikuDescription.AutoSize = true;
            this.linkLblHaikuDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblHaikuDescription.Location = new System.Drawing.Point(147, 9);
            this.linkLblHaikuDescription.MaximumSize = new System.Drawing.Size(800, 0);
            this.linkLblHaikuDescription.Name = "linkLblHaikuDescription";
            this.linkLblHaikuDescription.Size = new System.Drawing.Size(605, 90);
            this.linkLblHaikuDescription.TabIndex = 1;
            this.linkLblHaikuDescription.TabStop = true;
            this.linkLblHaikuDescription.Text = resources.GetString("linkLblHaikuDescription.Text");
            this.linkLblHaikuDescription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblHaikuDescription_LinkClicked);
            // 
            // txtBoxFirstPhrase
            // 
            this.txtBoxFirstPhrase.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFirstPhrase.Multiline = true;
            this.txtBoxFirstPhrase.Name = "txtBoxFirstPhrase";
            this.txtBoxFirstPhrase.Size = new System.Drawing.Size(387, 41);
            this.txtBoxFirstPhrase.TabIndex = 2;
            // 
            // groupBoxPhraseOne
            // 
            this.groupBoxPhraseOne.Controls.Add(this.txtBoxFirstPhrase);
            this.groupBoxPhraseOne.Location = new System.Drawing.Point(6, 19);
            this.groupBoxPhraseOne.Name = "groupBoxPhraseOne";
            this.groupBoxPhraseOne.Size = new System.Drawing.Size(399, 67);
            this.groupBoxPhraseOne.TabIndex = 3;
            this.groupBoxPhraseOne.TabStop = false;
            this.groupBoxPhraseOne.Text = "Please enter your first phrase - 5 Syllables";
            // 
            // groupBoxYourHaiku
            // 
            this.groupBoxYourHaiku.Controls.Add(this.btnPrint);
            this.groupBoxYourHaiku.Controls.Add(this.btnValidate);
            this.groupBoxYourHaiku.Controls.Add(this.groupBoxThirdPhrase);
            this.groupBoxYourHaiku.Controls.Add(this.groupBoxSecondPhrase);
            this.groupBoxYourHaiku.Controls.Add(this.groupBoxPhraseOne);
            this.groupBoxYourHaiku.Location = new System.Drawing.Point(12, 121);
            this.groupBoxYourHaiku.Name = "groupBoxYourHaiku";
            this.groupBoxYourHaiku.Size = new System.Drawing.Size(724, 294);
            this.groupBoxYourHaiku.TabIndex = 4;
            this.groupBoxYourHaiku.TabStop = false;
            this.groupBoxYourHaiku.Text = "Your Haiku";
            // 
            // groupBoxSecondPhrase
            // 
            this.groupBoxSecondPhrase.Controls.Add(this.txtBoxSecondPhrase);
            this.groupBoxSecondPhrase.Location = new System.Drawing.Point(6, 108);
            this.groupBoxSecondPhrase.Name = "groupBoxSecondPhrase";
            this.groupBoxSecondPhrase.Size = new System.Drawing.Size(399, 67);
            this.groupBoxSecondPhrase.TabIndex = 4;
            this.groupBoxSecondPhrase.TabStop = false;
            this.groupBoxSecondPhrase.Text = "Please enter your second phrase - 7 Syllables";
            // 
            // txtBoxSecondPhrase
            // 
            this.txtBoxSecondPhrase.Location = new System.Drawing.Point(6, 19);
            this.txtBoxSecondPhrase.Multiline = true;
            this.txtBoxSecondPhrase.Name = "txtBoxSecondPhrase";
            this.txtBoxSecondPhrase.Size = new System.Drawing.Size(387, 41);
            this.txtBoxSecondPhrase.TabIndex = 2;
            // 
            // groupBoxThirdPhrase
            // 
            this.groupBoxThirdPhrase.Controls.Add(this.txtBoxThirdPhrase);
            this.groupBoxThirdPhrase.Location = new System.Drawing.Point(6, 212);
            this.groupBoxThirdPhrase.Name = "groupBoxThirdPhrase";
            this.groupBoxThirdPhrase.Size = new System.Drawing.Size(399, 67);
            this.groupBoxThirdPhrase.TabIndex = 5;
            this.groupBoxThirdPhrase.TabStop = false;
            this.groupBoxThirdPhrase.Text = "Please enter your third phrase - 5 Syllables";
            // 
            // txtBoxThirdPhrase
            // 
            this.txtBoxThirdPhrase.Location = new System.Drawing.Point(6, 19);
            this.txtBoxThirdPhrase.Multiline = true;
            this.txtBoxThirdPhrase.Name = "txtBoxThirdPhrase";
            this.txtBoxThirdPhrase.Size = new System.Drawing.Size(387, 41);
            this.txtBoxThirdPhrase.TabIndex = 2;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(519, 30);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(152, 49);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(519, 230);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(152, 49);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // HaikuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 427);
            this.Controls.Add(this.groupBoxYourHaiku);
            this.Controls.Add(this.linkLblHaikuDescription);
            this.Controls.Add(this.titleHaiku);
            this.Name = "HaikuForm";
            this.Text = "HaikuForm";
            this.groupBoxPhraseOne.ResumeLayout(false);
            this.groupBoxPhraseOne.PerformLayout();
            this.groupBoxYourHaiku.ResumeLayout(false);
            this.groupBoxSecondPhrase.ResumeLayout(false);
            this.groupBoxSecondPhrase.PerformLayout();
            this.groupBoxThirdPhrase.ResumeLayout(false);
            this.groupBoxThirdPhrase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleHaiku;
        private System.Windows.Forms.LinkLabel linkLblHaikuDescription;
        private System.Windows.Forms.TextBox txtBoxFirstPhrase;
        private System.Windows.Forms.GroupBox groupBoxPhraseOne;
        private System.Windows.Forms.GroupBox groupBoxYourHaiku;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.GroupBox groupBoxThirdPhrase;
        private System.Windows.Forms.TextBox txtBoxThirdPhrase;
        private System.Windows.Forms.GroupBox groupBoxSecondPhrase;
        private System.Windows.Forms.TextBox txtBoxSecondPhrase;
    }
}