namespace Atelier2_ex2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Serv_Volail = new System.Windows.Forms.Button();
            this.Btn_Serv_Viande = new System.Windows.Forms.Button();
            this.Lst_Volailles = new System.Windows.Forms.ListBox();
            this.Lst_Viandes = new System.Windows.Forms.ListBox();
            this.Rdb_Volailles = new System.Windows.Forms.RadioButton();
            this.Rdb_Viandes = new System.Windows.Forms.RadioButton();
            this.Btn_Tirer = new System.Windows.Forms.Button();
            this.btn_Init = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Tirer);
            this.groupBox1.Controls.Add(this.Rdb_Viandes);
            this.groupBox1.Controls.Add(this.Rdb_Volailles);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lst_Volailles);
            this.groupBox2.Controls.Add(this.Btn_Serv_Volail);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volailles";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Init);
            this.groupBox3.Controls.Add(this.Lst_Viandes);
            this.groupBox3.Controls.Add(this.Btn_Serv_Viande);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(246, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 374);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Viandes";
            // 
            // Btn_Serv_Volail
            // 
            this.Btn_Serv_Volail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Serv_Volail.Location = new System.Drawing.Point(30, 50);
            this.Btn_Serv_Volail.Name = "Btn_Serv_Volail";
            this.Btn_Serv_Volail.Size = new System.Drawing.Size(126, 38);
            this.Btn_Serv_Volail.TabIndex = 0;
            this.Btn_Serv_Volail.Text = "Se Servir";
            this.Btn_Serv_Volail.UseVisualStyleBackColor = true;
            this.Btn_Serv_Volail.Click += new System.EventHandler(this.Btn_Serv_Volail_Click);
            // 
            // Btn_Serv_Viande
            // 
            this.Btn_Serv_Viande.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Serv_Viande.Location = new System.Drawing.Point(30, 50);
            this.Btn_Serv_Viande.Name = "Btn_Serv_Viande";
            this.Btn_Serv_Viande.Size = new System.Drawing.Size(128, 38);
            this.Btn_Serv_Viande.TabIndex = 0;
            this.Btn_Serv_Viande.Text = "Se Servir";
            this.Btn_Serv_Viande.UseVisualStyleBackColor = true;
            this.Btn_Serv_Viande.Click += new System.EventHandler(this.Btn_Serv_Viande_Click);
            // 
            // Lst_Volailles
            // 
            this.Lst_Volailles.FormattingEnabled = true;
            this.Lst_Volailles.ItemHeight = 22;
            this.Lst_Volailles.Location = new System.Drawing.Point(30, 109);
            this.Lst_Volailles.Name = "Lst_Volailles";
            this.Lst_Volailles.Size = new System.Drawing.Size(155, 224);
            this.Lst_Volailles.TabIndex = 1;
            // 
            // Lst_Viandes
            // 
            this.Lst_Viandes.FormattingEnabled = true;
            this.Lst_Viandes.ItemHeight = 22;
            this.Lst_Viandes.Location = new System.Drawing.Point(30, 109);
            this.Lst_Viandes.Name = "Lst_Viandes";
            this.Lst_Viandes.Size = new System.Drawing.Size(153, 224);
            this.Lst_Viandes.TabIndex = 1;
            // 
            // Rdb_Volailles
            // 
            this.Rdb_Volailles.AutoSize = true;
            this.Rdb_Volailles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Rdb_Volailles.ForeColor = System.Drawing.Color.Goldenrod;
            this.Rdb_Volailles.Location = new System.Drawing.Point(18, 36);
            this.Rdb_Volailles.Name = "Rdb_Volailles";
            this.Rdb_Volailles.Size = new System.Drawing.Size(101, 28);
            this.Rdb_Volailles.TabIndex = 0;
            this.Rdb_Volailles.TabStop = true;
            this.Rdb_Volailles.Text = "Volailles";
            this.Rdb_Volailles.UseVisualStyleBackColor = true;
            // 
            // Rdb_Viandes
            // 
            this.Rdb_Viandes.AutoSize = true;
            this.Rdb_Viandes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Rdb_Viandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Rdb_Viandes.ForeColor = System.Drawing.Color.Red;
            this.Rdb_Viandes.Location = new System.Drawing.Point(127, 36);
            this.Rdb_Viandes.Name = "Rdb_Viandes";
            this.Rdb_Viandes.Size = new System.Drawing.Size(100, 28);
            this.Rdb_Viandes.TabIndex = 1;
            this.Rdb_Viandes.TabStop = true;
            this.Rdb_Viandes.Text = "Viandes";
            this.Rdb_Viandes.UseVisualStyleBackColor = false;
            this.Rdb_Viandes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Btn_Tirer
            // 
            this.Btn_Tirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Btn_Tirer.Location = new System.Drawing.Point(264, 21);
            this.Btn_Tirer.Name = "Btn_Tirer";
            this.Btn_Tirer.Size = new System.Drawing.Size(146, 39);
            this.Btn_Tirer.TabIndex = 2;
            this.Btn_Tirer.Text = "Tirer un Ticket";
            this.Btn_Tirer.UseVisualStyleBackColor = true;
            this.Btn_Tirer.Click += new System.EventHandler(this.Btn_Tirer_Click);
            // 
            // btn_Init
            // 
            this.btn_Init.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Init.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Init.Location = new System.Drawing.Point(46, 339);
            this.btn_Init.Name = "btn_Init";
            this.btn_Init.Size = new System.Drawing.Size(130, 32);
            this.btn_Init.TabIndex = 2;
            this.btn_Init.Text = "Initialiser";
            this.btn_Init.UseVisualStyleBackColor = true;
            this.btn_Init.Click += new System.EventHandler(this.btn_Init_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Tirer;
        private System.Windows.Forms.RadioButton Rdb_Viandes;
        private System.Windows.Forms.RadioButton Rdb_Volailles;
        private System.Windows.Forms.ListBox Lst_Volailles;
        private System.Windows.Forms.Button Btn_Serv_Volail;
        private System.Windows.Forms.ListBox Lst_Viandes;
        private System.Windows.Forms.Button Btn_Serv_Viande;
        private System.Windows.Forms.Button btn_Init;
    }
}

