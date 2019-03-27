namespace Biométrie
{
    partial class Ajout
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.URLTXT = new System.Windows.Forms.TextBox();
            this.identTXT = new System.Windows.Forms.TextBox();
            this.passTXT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identifiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mots de passe";
            // 
            // URLTXT
            // 
            this.URLTXT.Location = new System.Drawing.Point(112, 10);
            this.URLTXT.Name = "URLTXT";
            this.URLTXT.Size = new System.Drawing.Size(100, 20);
            this.URLTXT.TabIndex = 3;
            // 
            // identTXT
            // 
            this.identTXT.Location = new System.Drawing.Point(112, 40);
            this.identTXT.Name = "identTXT";
            this.identTXT.Size = new System.Drawing.Size(100, 20);
            this.identTXT.TabIndex = 4;
            // 
            // passTXT
            // 
            this.passTXT.Location = new System.Drawing.Point(112, 70);
            this.passTXT.Name = "passTXT";
            this.passTXT.Size = new System.Drawing.Size(100, 20);
            this.passTXT.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 146);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passTXT);
            this.Controls.Add(this.identTXT);
            this.Controls.Add(this.URLTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(245, 185);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(245, 185);
            this.Name = "Ajout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ajout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox URLTXT;
        private System.Windows.Forms.TextBox identTXT;
        private System.Windows.Forms.TextBox passTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}