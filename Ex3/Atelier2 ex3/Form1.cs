using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier2_ex3
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> Dict_Def = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Nouveau_Click(object sender, EventArgs e)
        {
            Txt_Mot.Clear();
            Txt_Mot.Focus();
            Txt_Def.Clear();
            Txt_Def.Focus();

        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            string Mot = Txt_Mot.Text;
            string Definition = Txt_Def.Text;
            if (!string.IsNullOrEmpty(Mot) && !string.IsNullOrEmpty(Definition))
            {
                Dict_Def[Mot] = Definition;
                Dg_Mot.Rows.Add(Mot,Definition);
            }
            else
            { 
                MessageBox.Show("Veuillez saisir un mot et une définition.");
            }

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            string Mot = Txt_Mot.Text;
            string Definition = Txt_Def.Text;

            if (Dict_Def.ContainsKey(Mot))
            {
                Dict_Def.Remove(Mot);
                MessageBox.Show($"Le mot '{Mot}' et sa définition ont été supprimés.");

                foreach (DataGridViewRow row in Dg_Mot.Rows)
                {
                    if (row.Cells[0].Value?.ToString() == Mot) 
                    {
                        Dg_Mot.Rows.Remove(row);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show($"Le mot '{Mot}' n'existe pas dans le dictionnaire.");
            }

            Txt_Mot.Clear();
            Txt_Def.Clear();
        }

        private void Btn_Recherche_Click(object sender, EventArgs e)
        {
            string mot = Txt_Mot.Text;
            string definition = Txt_Def.Text;
            if (Dict_Def.ContainsKey(mot))
            {
                Dict_Def[mot] = definition;
                MessageBox.Show("La définition du mot "+  mot + "  a été trouvé");
            }
            else
            {
                MessageBox.Show("Le mot " +mot + "  n\'existe pas dans le dictionnaire.");
            }

        }

        private void Btn_Vider_Click(object sender, EventArgs e)
        {
            Dict_Def.Clear();
            MessageBox.Show("Le dictionnaire a été vidé.");
            Dg_Mot.Rows.Clear();
        }
    }
}
