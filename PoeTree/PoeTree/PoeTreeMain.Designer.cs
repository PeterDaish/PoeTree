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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnHaiku = new System.Windows.Forms.Button();
            this.groupBoxMenuOptions = new System.Windows.Forms.GroupBox();
            this.btnFreeForm = new System.Windows.Forms.Button();
            this.btnSonnet = new System.Windows.Forms.Button();
            this.groupBoxMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(264, 9);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(267, 31);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Welcome to PoeTree";
            // 
            // btnHaiku
            // 
            this.btnHaiku.Location = new System.Drawing.Point(6, 66);
            this.btnHaiku.Name = "btnHaiku";
            this.btnHaiku.Size = new System.Drawing.Size(136, 51);
            this.btnHaiku.TabIndex = 1;
            this.btnHaiku.Text = "Haiku";
            this.btnHaiku.UseVisualStyleBackColor = true;
            this.btnHaiku.Click += new System.EventHandler(this.btnHaiku_Click);
            // 
            // groupBoxMenuOptions
            // 
            this.groupBoxMenuOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMenuOptions.Controls.Add(this.btnSonnet);
            this.groupBoxMenuOptions.Controls.Add(this.btnFreeForm);
            this.groupBoxMenuOptions.Controls.Add(this.btnHaiku);
            this.groupBoxMenuOptions.Location = new System.Drawing.Point(12, 268);
            this.groupBoxMenuOptions.Name = "groupBoxMenuOptions";
            this.groupBoxMenuOptions.Size = new System.Drawing.Size(776, 170);
            this.groupBoxMenuOptions.TabIndex = 2;
            this.groupBoxMenuOptions.TabStop = false;
            this.groupBoxMenuOptions.Text = "Please choose which type of Poem you wish to create";
            // 
            // btnFreeForm
            // 
            this.btnFreeForm.Location = new System.Drawing.Point(327, 66);
            this.btnFreeForm.Name = "btnFreeForm";
            this.btnFreeForm.Size = new System.Drawing.Size(136, 51);
            this.btnFreeForm.TabIndex = 3;
            this.btnFreeForm.Text = "Free Form Poetry";
            this.btnFreeForm.UseVisualStyleBackColor = true;
            // 
            // btnSonnet
            // 
            this.btnSonnet.Location = new System.Drawing.Point(634, 66);
            this.btnSonnet.Name = "btnSonnet";
            this.btnSonnet.Size = new System.Drawing.Size(136, 51);
            this.btnSonnet.TabIndex = 4;
            this.btnSonnet.Text = "Sonnets";
            this.btnSonnet.UseVisualStyleBackColor = true;
            // 
            // PoeTreeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxMenuOptions);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "PoeTreeMain";
            this.Text = "PoeTree";
            this.groupBoxMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnHaiku;
        private System.Windows.Forms.GroupBox groupBoxMenuOptions;
        private System.Windows.Forms.Button btnFreeForm;
        private System.Windows.Forms.Button btnSonnet;
    }
}

