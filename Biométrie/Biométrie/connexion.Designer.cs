namespace Biométrie
{
    partial class connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion));
            this.bt_inscription = new System.Windows.Forms.Button();
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
            // bt_inscription
            // 
            this.bt_inscription.Location = new System.Drawing.Point(-1, 242);
            this.bt_inscription.Name = "bt_inscription";
            this.bt_inscription.Size = new System.Drawing.Size(508, 39);
            this.bt_inscription.TabIndex = 19;
            this.bt_inscription.Text = "Inscription";
            this.bt_inscription.UseVisualStyleBackColor = true;
            this.bt_inscription.Click += new System.EventHandler(this.bt_inscription_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 131);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 89);
            this.textBox1.TabIndex = 18;
            // 
            // bt_ouvrir
            // 
            this.bt_ouvrir.Location = new System.Drawing.Point(358, 102);
            this.bt_ouvrir.Name = "bt_ouvrir";
            this.bt_ouvrir.Size = new System.Drawing.Size(121, 23);
            this.bt_ouvrir.TabIndex = 17;
            this.bt_ouvrir.Text = "Ouvrir";
            this.bt_ouvrir.UseVisualStyleBackColor = true;
            this.bt_ouvrir.Click += new System.EventHandler(this.bt_ouvrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ports : ";
            // 
            // combousb
            // 
            this.combousb.FormattingEnabled = true;
            this.combousb.Location = new System.Drawing.Point(358, 75);
            this.combousb.Name = "combousb";
            this.combousb.Size = new System.Drawing.Size(121, 21);
            this.combousb.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // LB_insctruction
            // 
            this.LB_insctruction.AutoSize = true;
            this.LB_insctruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_insctruction.Location = new System.Drawing.Point(14, 15);
            this.LB_insctruction.Name = "LB_insctruction";
            this.LB_insctruction.Size = new System.Drawing.Size(461, 25);
            this.LB_insctruction.TabIndex = 13;
            this.LB_insctruction.Text = "Posez votre doigtsur le capteur pour vous connecter";
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 280);
            this.Controls.Add(this.bt_inscription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_ouvrir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combousb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_insctruction);
            this.MaximumSize = new System.Drawing.Size(522, 319);
            this.MinimumSize = new System.Drawing.Size(522, 319);
            this.Name = "connexion";
            this.Text = "connexion";
            this.Load += new System.EventHandler(this.connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_inscription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_ouvrir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combousb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_insctruction;
        private System.IO.Ports.SerialPort serialPort1;
    }
}