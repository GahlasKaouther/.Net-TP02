namespace Atelier_2_ex1
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_Supp = new System.Windows.Forms.Button();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Txt_Note = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Convertir = new System.Windows.Forms.Button();
            this.Txt_Chaine = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Supp_Tous = new System.Windows.Forms.Button();
            this.Rdb_Egal_10 = new System.Windows.Forms.CheckBox();
            this.Rdb_Inf_10 = new System.Windows.Forms.CheckBox();
            this.Rdb_Sup_10 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Rech = new System.Windows.Forms.Button();
            this.Txt_Rech = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Vider = new System.Windows.Forms.Button();
            this.Btn_Inverser = new System.Windows.Forms.Button();
            this.Btn_Trier = new System.Windows.Forms.Button();
            this.Lst_Int = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.Btn_Convertir);
            this.groupBox1.Controls.Add(this.Txt_Chaine);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions sur Liste";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_Supp);
            this.groupBox5.Controls.Add(this.Btn_Ajout);
            this.groupBox5.Controls.Add(this.Txt_Note);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(17, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(436, 124);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // Btn_Supp
            // 
            this.Btn_Supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Supp.Location = new System.Drawing.Point(204, 64);
            this.Btn_Supp.Name = "Btn_Supp";
            this.Btn_Supp.Size = new System.Drawing.Size(205, 49);
            this.Btn_Supp.TabIndex = 3;
            this.Btn_Supp.Text = "Supprimer élément sélectionné";
            this.Btn_Supp.UseVisualStyleBackColor = true;
            this.Btn_Supp.Click += new System.EventHandler(this.Btn_Supp_Click);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Ajout.Location = new System.Drawing.Point(88, 64);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(84, 49);
            this.Btn_Ajout.TabIndex = 2;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Txt_Note
            // 
            this.Txt_Note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Note.Location = new System.Drawing.Point(188, 23);
            this.Txt_Note.Name = "Txt_Note";
            this.Txt_Note.Size = new System.Drawing.Size(221, 28);
            this.Txt_Note.TabIndex = 1;
            this.Txt_Note.TextChanged += new System.EventHandler(this.Txt_Note_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donner une Note :";
            // 
            // Btn_Convertir
            // 
            this.Btn_Convertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Convertir.Location = new System.Drawing.Point(315, 364);
            this.Btn_Convertir.Name = "Btn_Convertir";
            this.Btn_Convertir.Size = new System.Drawing.Size(152, 59);
            this.Btn_Convertir.TabIndex = 3;
            this.Btn_Convertir.Text = "Convertir en chaine";
            this.Btn_Convertir.UseVisualStyleBackColor = true;
            this.Btn_Convertir.Click += new System.EventHandler(this.Btn_Convertir_Click);
            // 
            // Txt_Chaine
            // 
            this.Txt_Chaine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Chaine.Location = new System.Drawing.Point(42, 378);
            this.Txt_Chaine.Name = "Txt_Chaine";
            this.Txt_Chaine.Size = new System.Drawing.Size(267, 28);
            this.Txt_Chaine.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Supp_Tous);
            this.groupBox3.Controls.Add(this.Rdb_Egal_10);
            this.groupBox3.Controls.Add(this.Rdb_Inf_10);
            this.groupBox3.Controls.Add(this.Rdb_Sup_10);
            this.groupBox3.Location = new System.Drawing.Point(17, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 109);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supression avec condition";
            // 
            // Btn_Supp_Tous
            // 
            this.Btn_Supp_Tous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Supp_Tous.Location = new System.Drawing.Point(262, 63);
            this.Btn_Supp_Tous.Name = "Btn_Supp_Tous";
            this.Btn_Supp_Tous.Size = new System.Drawing.Size(160, 33);
            this.Btn_Supp_Tous.TabIndex = 3;
            this.Btn_Supp_Tous.Text = "Supprimer Tous";
            this.Btn_Supp_Tous.UseVisualStyleBackColor = true;
            this.Btn_Supp_Tous.Click += new System.EventHandler(this.Btn_Supp_Tous_Click);
            // 
            // Rdb_Egal_10
            // 
            this.Rdb_Egal_10.AutoSize = true;
            this.Rdb_Egal_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rdb_Egal_10.Location = new System.Drawing.Point(302, 33);
            this.Rdb_Egal_10.Name = "Rdb_Egal_10";
            this.Rdb_Egal_10.Size = new System.Drawing.Size(64, 24);
            this.Rdb_Egal_10.TabIndex = 2;
            this.Rdb_Egal_10.Text = "= 10";
            this.Rdb_Egal_10.UseVisualStyleBackColor = true;
            // 
            // Rdb_Inf_10
            // 
            this.Rdb_Inf_10.AutoSize = true;
            this.Rdb_Inf_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rdb_Inf_10.Location = new System.Drawing.Point(160, 33);
            this.Rdb_Inf_10.Name = "Rdb_Inf_10";
            this.Rdb_Inf_10.Size = new System.Drawing.Size(64, 24);
            this.Rdb_Inf_10.TabIndex = 1;
            this.Rdb_Inf_10.Text = "< 10";
            this.Rdb_Inf_10.UseVisualStyleBackColor = true;
            // 
            // Rdb_Sup_10
            // 
            this.Rdb_Sup_10.AutoSize = true;
            this.Rdb_Sup_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rdb_Sup_10.Location = new System.Drawing.Point(25, 33);
            this.Rdb_Sup_10.Name = "Rdb_Sup_10";
            this.Rdb_Sup_10.Size = new System.Drawing.Size(64, 24);
            this.Rdb_Sup_10.TabIndex = 0;
            this.Rdb_Sup_10.Text = "> 10";
            this.Rdb_Sup_10.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Rech);
            this.groupBox2.Controls.Add(this.Txt_Rech);
            this.groupBox2.Location = new System.Drawing.Point(17, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche de l\'existance d\'une valeur";
            // 
            // Btn_Rech
            // 
            this.Btn_Rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Rech.Location = new System.Drawing.Point(262, 27);
            this.Btn_Rech.Name = "Btn_Rech";
            this.Btn_Rech.Size = new System.Drawing.Size(135, 37);
            this.Btn_Rech.TabIndex = 1;
            this.Btn_Rech.Text = "Rechercher";
            this.Btn_Rech.UseVisualStyleBackColor = true;
            this.Btn_Rech.Click += new System.EventHandler(this.Btn_Rech_Click);
            // 
            // Txt_Rech
            // 
            this.Txt_Rech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Rech.Location = new System.Drawing.Point(46, 31);
            this.Txt_Rech.Name = "Txt_Rech";
            this.Txt_Rech.Size = new System.Drawing.Size(210, 28);
            this.Txt_Rech.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_Vider);
            this.groupBox4.Controls.Add(this.Btn_Inverser);
            this.groupBox4.Controls.Add(this.Btn_Trier);
            this.groupBox4.Controls.Add(this.Lst_Int);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox4.Location = new System.Drawing.Point(523, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 426);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liste d\'entiers";
            // 
            // Btn_Vider
            // 
            this.Btn_Vider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Vider.Location = new System.Drawing.Point(69, 394);
            this.Btn_Vider.Name = "Btn_Vider";
            this.Btn_Vider.Size = new System.Drawing.Size(84, 29);
            this.Btn_Vider.TabIndex = 3;
            this.Btn_Vider.Text = "Vider";
            this.Btn_Vider.UseVisualStyleBackColor = true;
            this.Btn_Vider.Click += new System.EventHandler(this.Btn_Vider_Click);
            // 
            // Btn_Inverser
            // 
            this.Btn_Inverser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Inverser.Location = new System.Drawing.Point(69, 364);
            this.Btn_Inverser.Name = "Btn_Inverser";
            this.Btn_Inverser.Size = new System.Drawing.Size(84, 29);
            this.Btn_Inverser.TabIndex = 2;
            this.Btn_Inverser.Text = "Inverser";
            this.Btn_Inverser.UseVisualStyleBackColor = true;
            this.Btn_Inverser.Click += new System.EventHandler(this.Btn_Inverser_Click);
            // 
            // Btn_Trier
            // 
            this.Btn_Trier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Trier.Location = new System.Drawing.Point(69, 331);
            this.Btn_Trier.Name = "Btn_Trier";
            this.Btn_Trier.Size = new System.Drawing.Size(84, 29);
            this.Btn_Trier.TabIndex = 1;
            this.Btn_Trier.Text = "Trier";
            this.Btn_Trier.UseVisualStyleBackColor = true;
            this.Btn_Trier.Click += new System.EventHandler(this.Btn_Trier_Click);
            // 
            // Lst_Int
            // 
            this.Lst_Int.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lst_Int.FormattingEnabled = true;
            this.Lst_Int.ItemHeight = 20;
            this.Lst_Int.Location = new System.Drawing.Point(17, 41);
            this.Lst_Int.Name = "Lst_Int";
            this.Lst_Int.Size = new System.Drawing.Size(177, 284);
            this.Lst_Int.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "La gestion des collections: List<T>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Convertir;
        private System.Windows.Forms.TextBox Txt_Chaine;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Rech;
        private System.Windows.Forms.TextBox Txt_Rech;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_Supp;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.TextBox Txt_Note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Supp_Tous;
        private System.Windows.Forms.CheckBox Rdb_Egal_10;
        private System.Windows.Forms.CheckBox Rdb_Inf_10;
        private System.Windows.Forms.CheckBox Rdb_Sup_10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_Vider;
        private System.Windows.Forms.Button Btn_Inverser;
        private System.Windows.Forms.Button Btn_Trier;
        private System.Windows.Forms.ListBox Lst_Int;
    }
}

