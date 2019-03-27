namespace Biométrie
{
    partial class inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inscription));
            this.valider = new System.Windows.Forms.Button();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_ouvrir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combousb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_insctruction = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(218, 226);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(74, 30);
            this.valider.TabIndex = 21;
            this.valider.Text = "S\'inscrire";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(87, 251);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(87, 224);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 89);
            this.textBox1.TabIndex = 16;
            // 
            // bt_ouvrir
            // 
            this.bt_ouvrir.Location = new System.Drawing.Point(361, 93);
            this.bt_ouvrir.Name = "bt_ouvrir";
            this.bt_ouvrir.Size = new System.Drawing.Size(121, 23);
            this.bt_ouvrir.TabIndex = 15;
            this.bt_ouvrir.Text = "Ouvrir";
            this.bt_ouvrir.UseVisualStyleBackColor = true;
            this.bt_ouvrir.Click += new System.EventHandler(this.bt_ouvrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ports : ";
            // 
            // combousb
            // 
            this.combousb.FormattingEnabled = true;
            this.combousb.Location = new System.Drawing.Point(361, 66);
            this.combousb.Name = "combousb";
            this.combousb.Size = new System.Drawing.Size(121, 21);
            this.combousb.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LB_insctruction
            // 
            this.LB_insctruction.AutoSize = true;
            this.LB_insctruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_insctruction.Location = new System.Drawing.Point(17, 9);
            this.LB_insctruction.Name = "LB_insctruction";
            this.LB_insctruction.Size = new System.Drawing.Size(305, 20);
            this.LB_insctruction.TabIndex = 11;
            this.LB_insctruction.Text = "Veuillez suivre les insctruction d\'inscription";
            // 
            // inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 283);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_ouvrir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combousb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_insctruction);
            this.Name = "inscription";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_ouvrir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combousb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_insctruction;
        private System.IO.Ports.SerialPort serialPort1;
    }
}