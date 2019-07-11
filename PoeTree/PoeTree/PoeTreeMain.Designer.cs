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
            this.lbl_HelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_HelloWorld
            // 
            this.lbl_HelloWorld.AutoSize = true;
            this.lbl_HelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HelloWorld.Location = new System.Drawing.Point(260, 112);
            this.lbl_HelloWorld.Name = "lbl_HelloWorld";
            this.lbl_HelloWorld.Size = new System.Drawing.Size(153, 31);
            this.lbl_HelloWorld.TabIndex = 0;
            this.lbl_HelloWorld.Text = "Hello World";
            // 
            // PoeTreeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_HelloWorld);
            this.Name = "PoeTreeMain";
            this.Text = "PoeTree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HelloWorld;
    }
}

