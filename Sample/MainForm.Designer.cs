namespace Sample
{
    partial class MainForm
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
            this.mesajKutusuButton = new System.Windows.Forms.Button();
            this.messageBoxHelperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mesajKutusuButton
            // 
            this.mesajKutusuButton.Location = new System.Drawing.Point(12, 12);
            this.mesajKutusuButton.Name = "mesajKutusuButton";
            this.mesajKutusuButton.Size = new System.Drawing.Size(106, 23);
            this.mesajKutusuButton.TabIndex = 0;
            this.mesajKutusuButton.Text = "MesajKutusu";
            this.mesajKutusuButton.UseVisualStyleBackColor = true;
            this.mesajKutusuButton.Click += new System.EventHandler(this.MesajKutusuButton_Click);
            // 
            // messageBoxHelperButton
            // 
            this.messageBoxHelperButton.Location = new System.Drawing.Point(124, 12);
            this.messageBoxHelperButton.Name = "messageBoxHelperButton";
            this.messageBoxHelperButton.Size = new System.Drawing.Size(147, 23);
            this.messageBoxHelperButton.TabIndex = 1;
            this.messageBoxHelperButton.Text = "MessageBoxHelper";
            this.messageBoxHelperButton.UseVisualStyleBackColor = true;
            this.messageBoxHelperButton.Click += new System.EventHandler(this.MessageBoxHelperButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageBoxHelperButton);
            this.Controls.Add(this.mesajKutusuButton);
            this.Name = "MainForm";
            this.Text = "Zeytinbey.Windows.Forms Sample Application";
            this.ResumeLayout(false);

        }

        #endregion

        private Button mesajKutusuButton;
        private Button messageBoxHelperButton;
    }
}