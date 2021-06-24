using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            lstitens.Items.Add(txtitem.Text);
            txtitem.Clear();
            txtitem.Focus();




        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lstitens.Items.Clear();
        }

        private void btnapagaritem_Click(object sender, EventArgs e)
        {
            lstitens.Items.Remove(txtitem.Text);
        }

        private void btnselecao_Click(object sender, EventArgs e)
        {
            lstitens.Items.Remove(lstitens.SelectedItem);
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            int indice1;
            indice1 = int.Parse(txtindice.Text);

            lstitens.Items.Insert(indice1, txtitem.Text);
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            lstitens.Sorted = true;
        }

        private void btnmselecao_Click(object sender, EventArgs e)
        {
            txtselecionado.Text = lstitens.SelectedItem.ToString();
        }
    }
}
