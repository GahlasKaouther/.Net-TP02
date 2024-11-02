using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_2_ex1
{
    public partial class Form1 : Form
    {
        List<float> LIST_Int = new List<float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Note_TextChanged(object sender, EventArgs e)
        {

        }

        private void Afficher_liste()
        {
            Lst_Int.Items.Clear();
            foreach (float n in LIST_Int)
            {
                Lst_Int.Items.Add(n);
            }
        }
        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Note.Text))// (Txt_Note.Text == "") 
            {
                MessageBox.Show("zone vide");
            }
            else
            {

                try
                {
                    float note = float.Parse(Txt_Note.Text);
                    if (note < 0 || note > 20)
                    {
                        MessageBox.Show("erreur :  veuillez entrer une note entre 0 et 20 ");
                    }
                    else
                    {
                        LIST_Int.Add(note);
                        Afficher_liste();//methode pour actualiser l'affichage
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {
            if (Lst_Int.SelectedItem != null)
            {
                LIST_Int.RemoveAt(Lst_Int.SelectedIndex);
                Afficher_liste();
            }
            else
            {
                MessageBox.Show("veuillez selectionner un element");
            }

        }

        private void Btn_Supp_Tous_Click(object sender, EventArgs e)
        {
            //supprimer les notes>10
            if (Rdb_Sup_10.Checked)
            {
                LIST_Int.RemoveAll(x => x > 10);
                Afficher_liste();
            }
            //supprimer les notes<10
            if (Rdb_Inf_10.Checked)
            {
                LIST_Int.RemoveAll(x => x < 10);
                Afficher_liste();
            }
            //supprimer les notes=10
            if (Rdb_Egal_10.Checked)
            {
                LIST_Int.RemoveAll(x => x == 10);
                Afficher_liste();
            }
        }

        private void Btn_Rech_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Rech.Text))
            {
                MessageBox.Show("Veuillez entrer une valeur à rechercher.");
            }
            else
            {
                try
                {
                    float note = float.Parse(Txt_Rech.Text); 
                    if (LIST_Int.Contains(note))
                    {
                        MessageBox.Show("L'élément recherché est disponible.");
                    }
                    else
                    {
                        MessageBox.Show("L'élément recherché n'est pas disponible.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Veuillez entrer une valeur numérique valide.");
                }
            }

        }

        private void Btn_Convertir_Click(object sender, EventArgs e)
        {
            List<int> LIST_Int = new List<int>();
            foreach (var item in Lst_Int.Items)
            {
                LIST_Int.Add(Convert.ToInt32(item));
            }
            string chaine = string.Join(", ", LIST_Int);
            Txt_Chaine.Text = chaine;


        }

        private void Btn_Trier_Click(object sender, EventArgs e)
        {   
            List<int> LIST_Int = new List<int>();
            foreach (var item in Lst_Int.Items)
            {
                LIST_Int.Add(Convert.ToInt32(item));
            }
            LIST_Int.Sort();
            Lst_Int.Items.Clear();
            foreach (int item in LIST_Int)
            {
                Lst_Int.Items.Add(item);

            }
        }

        private void Btn_Inverser_Click(object sender, EventArgs e)
        {
            List<int> LIST_Int = new List<int>();
            foreach (var item in Lst_Int.Items)
            {
                LIST_Int.Add(Convert.ToInt32(item));
            }
            LIST_Int.Reverse();
            Lst_Int.Items.Clear();
            foreach (int item in LIST_Int)
            {
                Lst_Int.Items.Add(item);

            }
        }

        private void Btn_Vider_Click(object sender, EventArgs e)
        {
            Lst_Int.Items.Clear ();
            Txt_Chaine.Text = "";
            Txt_Note.Text = "";
            Txt_Rech.Text = "";
            Rdb_Egal_10.Checked = false;
            Rdb_Inf_10.Checked = false;
            Rdb_Sup_10.Checked = false;
             
        }
    }
}
