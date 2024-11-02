using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier2_ex2
{
    public partial class Form1 : Form
    {
        Queue<int> QVolailles = new Queue<int>();
        Queue<int> QViandes = new Queue<int>();
        int Tick_Vol = 1;
        int Tick_Viand = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Tirer_Click(object sender, EventArgs e)
        {

            if (!Rdb_Viandes.Checked && !Rdb_Volailles.Checked)
            {
                MessageBox.Show("veuillez choisir une option");
            }
            else
            {
                if (Rdb_Viandes.Checked)
                {
                    QViandes.Enqueue(Tick_Viand);
                    Lst_Viandes.Items.Add(Tick_Viand);
                    Tick_Viand++;
                }
                else if (Rdb_Volailles.Checked)
                {
                    QVolailles.Enqueue(Tick_Vol);
                    Lst_Volailles.Items.Add(Tick_Vol);
                    Tick_Vol++;
                }
            }
        }

        private void Btn_Serv_Volail_Click(object sender, EventArgs e)
        {
            if (QVolailles.Count > 0)
            {
                QVolailles.Dequeue();
                Lst_Volailles.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("la liste des volailles est vide");
            }
        }

        private void Btn_Serv_Viande_Click(object sender, EventArgs e)
        {
            if (QViandes.Count > 0)
            {
                QViandes.Dequeue();
                Lst_Viandes.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("la liste des viandes est vide");
            }
        }

        private void btn_Init_Click(object sender, EventArgs e)
        {
            Rdb_Viandes.Checked = false;
            Rdb_Volailles.Checked = false;
            Lst_Volailles.Items.Clear();
            Lst_Viandes.Items.Clear();
        }
    }
}
