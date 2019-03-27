namespace Biométrie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.gphistorique = new System.Windows.Forms.GroupBox();
            this.videhisto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vider = new System.Windows.Forms.ToolStripMenuItem();
            this.actualiserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historiquetxt = new System.Windows.Forms.TextBox();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPassword = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allerAuSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMemo = new System.Windows.Forms.TabPage();
            this.bt_enregistrer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.gphistorique.SuspendLayout();
            this.videhisto.SuspendLayout();
            this.tabPassword.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabMemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAccueil);
            this.tabControl1.Controls.Add(this.tabPassword);
            this.tabControl1.Controls.Add(this.tabMemo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(293, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 561);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabAccueil
            // 
            this.tabAccueil.BackColor = System.Drawing.Color.Transparent;
            this.tabAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabAccueil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAccueil.Controls.Add(this.gphistorique);
            this.tabAccueil.Controls.Add(this.lb_prenom);
            this.tabAccueil.Controls.Add(this.label1);
            this.tabAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAccueil.Location = new System.Drawing.Point(4, 34);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Size = new System.Drawing.Size(876, 523);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            // 
            // gphistorique
            // 
            this.gphistorique.ContextMenuStrip = this.videhisto;
            this.gphistorique.Controls.Add(this.historiquetxt);
            this.gphistorique.Location = new System.Drawing.Point(6, 371);
            this.gphistorique.Name = "gphistorique";
            this.gphistorique.Size = new System.Drawing.Size(861, 143);
            this.gphistorique.TabIndex = 2;
            this.gphistorique.TabStop = false;
            this.gphistorique.Text = "Historique";
            // 
            // videhisto
            // 
            this.videhisto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vider,
            this.actualiserToolStripMenuItem1});
            this.videhisto.Name = "videhisto";
            this.videhisto.Size = new System.Drawing.Size(127, 48);
            // 
            // vider
            // 
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(126, 22);
            this.vider.Text = "Vider";
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // actualiserToolStripMenuItem1
            // 
            this.actualiserToolStripMenuItem1.Name = "actualiserToolStripMenuItem1";
            this.actualiserToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.actualiserToolStripMenuItem1.Text = "Actualiser";
            this.actualiserToolStripMenuItem1.Click += new System.EventHandler(this.actualiserToolStripMenuItem1_Click);
            // 
            // historiquetxt
            // 
            this.historiquetxt.ContextMenuStrip = this.videhisto;
            this.historiquetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historiquetxt.Location = new System.Drawing.Point(6, 29);
            this.historiquetxt.Multiline = true;
            this.historiquetxt.Name = "historiquetxt";
            this.historiquetxt.ReadOnly = true;
            this.historiquetxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historiquetxt.Size = new System.Drawing.Size(849, 108);
            this.historiquetxt.TabIndex = 3;
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Location = new System.Drawing.Point(734, 15);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(80, 25);
            this.lb_prenom.TabIndex = 1;
            this.lb_prenom.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue";
            // 
            // tabPassword
            // 
            this.tabPassword.BackColor = System.Drawing.Color.Transparent;
            this.tabPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPassword.Controls.Add(this.listView1);
            this.tabPassword.Location = new System.Drawing.Point(4, 34);
            this.tabPassword.Name = "tabPassword";
            this.tabPassword.Size = new System.Drawing.Size(876, 523);
            this.tabPassword.TabIndex = 1;
            this.tabPassword.Text = "Vos mots de passe";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.URL,
            this.Login,
            this.Password});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(874, 521);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 207;
            // 
            // Login
            // 
            this.Login.Text = "Identifiant";
            this.Login.Width = 230;
            // 
            // Password
            // 
            this.Password.Text = "Mot de passe";
            this.Password.Width = 184;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualiserToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.motDePasseToolStripMenuItem,
            this.allerAuSiteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 114);
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // motDePasseToolStripMenuItem
            // 
            this.motDePasseToolStripMenuItem.Name = "motDePasseToolStripMenuItem";
            this.motDePasseToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.motDePasseToolStripMenuItem.Text = "Mot de passe";
            this.motDePasseToolStripMenuItem.Click += new System.EventHandler(this.motDePasseToolStripMenuItem_Click);
            // 
            // allerAuSiteToolStripMenuItem
            // 
            this.allerAuSiteToolStripMenuItem.Name = "allerAuSiteToolStripMenuItem";
            this.allerAuSiteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.allerAuSiteToolStripMenuItem.Text = "Aller au site";
            this.allerAuSiteToolStripMenuItem.Click += new System.EventHandler(this.allerAuSiteToolStripMenuItem_Click_1);
            // 
            // tabMemo
            // 
            this.tabMemo.BackColor = System.Drawing.Color.Transparent;
            this.tabMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMemo.Controls.Add(this.bt_enregistrer);
            this.tabMemo.Controls.Add(this.textBox1);
            this.tabMemo.Location = new System.Drawing.Point(4, 34);
            this.tabMemo.Name = "tabMemo";
            this.tabMemo.Size = new System.Drawing.Size(876, 523);
            this.tabMemo.TabIndex = 3;
            this.tabMemo.Text = "Memo";
            // 
            // bt_enregistrer
            // 
            this.bt_enregistrer.Location = new System.Drawing.Point(731, 489);
            this.bt_enregistrer.Name = "bt_enregistrer";
            this.bt_enregistrer.Size = new System.Drawing.Size(136, 29);
            this.bt_enregistrer.TabIndex = 1;
            this.bt_enregistrer.Text = "Enregistrer";
            this.bt_enregistrer.UseVisualStyleBackColor = true;
            this.bt_enregistrer.Click += new System.EventHandler(this.bt_enregistrer_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(865, 480);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Fingerpass - vos mots de passe aux bouts des doigts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.gphistorique.ResumeLayout(false);
            this.gphistorique.PerformLayout();
            this.videhisto.ResumeLayout(false);
            this.tabPassword.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabMemo.ResumeLayout(false);
            this.tabMemo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabPassword;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.TabPage tabMemo;
        private System.Windows.Forms.ToolStripMenuItem motDePasseToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_enregistrer;
        private System.Windows.Forms.ToolStripMenuItem allerAuSiteToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gphistorique;
        private System.Windows.Forms.TextBox historiquetxt;
        private System.Windows.Forms.ContextMenuStrip videhisto;
        private System.Windows.Forms.ToolStripMenuItem vider;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem1;
    }
}

