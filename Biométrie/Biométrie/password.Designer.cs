namespace Biométrie
{
    partial class password
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.copier = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Verifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 0;
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(12, 50);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(75, 23);
            this.enregistrer.TabIndex = 1;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(174, 50);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 2;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // copier
            // 
            this.copier.Location = new System.Drawing.Point(93, 50);
            this.copier.Name = "copier";
            this.copier.Size = new System.Drawing.Size(75, 23);
            this.copier.TabIndex = 3;
            this.copier.Text = "Copier";
            this.copier.UseVisualStyleBackColor = true;
            this.copier.Click += new System.EventHandler(this.copier_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            // 
            // Verifier
            // 
            this.Verifier.Location = new System.Drawing.Point(12, 50);
            this.Verifier.Name = "Verifier";
            this.Verifier.Size = new System.Drawing.Size(156, 23);
            this.Verifier.TabIndex = 5;
            this.Verifier.Text = "Valider votre identité";
            this.Verifier.UseVisualStyleBackColor = true;
            this.Verifier.Click += new System.EventHandler(this.verifier_Click);
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 85);
            this.ControlBox = false;
            this.Controls.Add(this.Verifier);
            this.Controls.Add(this.copier);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "password";
            this.Text = "password";
            this.Load += new System.EventHandler(this.password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button copier;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Verifier;
    }
}