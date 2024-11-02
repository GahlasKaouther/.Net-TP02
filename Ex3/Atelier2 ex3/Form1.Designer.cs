namespace Atelier2_ex3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Def = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Nouveau = new System.Windows.Forms.Button();
            this.Btn_Vider = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Recherche = new System.Windows.Forms.Button();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Txt_Mot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dg_Mot = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Mot)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Def);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_Nouveau);
            this.groupBox1.Controls.Add(this.Btn_Vider);
            this.groupBox1.Controls.Add(this.Btn_Supprimer);
            this.groupBox1.Controls.Add(this.Btn_Recherche);
            this.groupBox1.Controls.Add(this.Btn_Ajout);
            this.groupBox1.Controls.Add(this.Txt_Mot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie Mots/Définitions";
            // 
            // Txt_Def
            // 
            this.Txt_Def.Location = new System.Drawing.Point(118, 94);
            this.Txt_Def.Multiline = true;
            this.Txt_Def.Name = "Txt_Def";
            this.Txt_Def.Size = new System.Drawing.Size(420, 94);
            this.Txt_Def.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Définition :";
            // 
            // Btn_Nouveau
            // 
            this.Btn_Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Nouveau.Location = new System.Drawing.Point(440, 33);
            this.Btn_Nouveau.Name = "Btn_Nouveau";
            this.Btn_Nouveau.Size = new System.Drawing.Size(98, 36);
            this.Btn_Nouveau.TabIndex = 6;
            this.Btn_Nouveau.Text = "Nouveau";
            this.Btn_Nouveau.UseVisualStyleBackColor = true;
            this.Btn_Nouveau.Click += new System.EventHandler(this.Btn_Nouveau_Click);
            // 
            // Btn_Vider
            // 
            this.Btn_Vider.Location = new System.Drawing.Point(573, 166);
            this.Btn_Vider.Name = "Btn_Vider";
            this.Btn_Vider.Size = new System.Drawing.Size(113, 41);
            this.Btn_Vider.TabIndex = 5;
            this.Btn_Vider.Text = "Vider";
            this.Btn_Vider.UseVisualStyleBackColor = true;
            this.Btn_Vider.Click += new System.EventHandler(this.Btn_Vider_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Location = new System.Drawing.Point(573, 111);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(113, 55);
            this.Btn_Supprimer.TabIndex = 4;
            this.Btn_Supprimer.Text = "Supprimer un Mot";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Btn_Recherche
            // 
            this.Btn_Recherche.Location = new System.Drawing.Point(573, 64);
            this.Btn_Recherche.Name = "Btn_Recherche";
            this.Btn_Recherche.Size = new System.Drawing.Size(113, 41);
            this.Btn_Recherche.TabIndex = 3;
            this.Btn_Recherche.Text = "Rechercher";
            this.Btn_Recherche.UseVisualStyleBackColor = true;
            this.Btn_Recherche.Click += new System.EventHandler(this.Btn_Recherche_Click);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Location = new System.Drawing.Point(573, 17);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(113, 41);
            this.Btn_Ajout.TabIndex = 2;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Txt_Mot
            // 
            this.Txt_Mot.Location = new System.Drawing.Point(118, 38);
            this.Txt_Mot.Name = "Txt_Mot";
            this.Txt_Mot.Size = new System.Drawing.Size(293, 26);
            this.Txt_Mot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dg_Mot);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(25, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste Mots/Définitions";
            // 
            // Dg_Mot
            // 
            this.Dg_Mot.AllowUserToOrderColumns = true;
            this.Dg_Mot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Mot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Dg_Mot.Location = new System.Drawing.Point(6, 47);
            this.Dg_Mot.Name = "Dg_Mot";
            this.Dg_Mot.RowHeadersWidth = 51;
            this.Dg_Mot.RowTemplate.Height = 24;
            this.Dg_Mot.Size = new System.Drawing.Size(680, 128);
            this.Dg_Mot.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mot";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Définition";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mon Petit Dictionnaire";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Mot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Def;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Nouveau;
        private System.Windows.Forms.Button Btn_Vider;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Recherche;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.TextBox Txt_Mot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dg_Mot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

