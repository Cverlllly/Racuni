using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racuni
{
    public partial class Form1 : Form
    {
        Racun racun;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void vrsteRačunov_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox can only be used to select items
            this.vrsteRačunov.DropDownStyle = ComboBoxStyle.DropDownList;
            string pregled = vrsteRačunov.GetItemText(vrsteRačunov.SelectedItem);
            if (pregled == "Osebni račun")
            {
                osebnigroup.Enabled = true;
                valutnigroup.Enabled = false;
                poslovnigroup.Enabled = false;
            }
            else if (pregled == "Poslovni račun")
            {
                poslovnigroup.Enabled = true;
                valutnigroup.Enabled = false;
                osebnigroup.Enabled = false;
            }
            else if (pregled == "Valutni račun")
            {
                valutnigroup.Enabled = true;
                poslovnigroup.Enabled = false;
                osebnigroup.Enabled = false;
            }
        }

        private void ustvari_Click(object sender, EventArgs e)
        {
            var neki=imepriimek.Text.Split();
            var ime = neki[0];
            var priimek = neki[1];
            var stan = Convert.ToDouble(stanje.Text);
            var lim = Convert.ToDouble(limit.Text);
            MessageBox.Show(ime.ToString()+" "+ priimek.ToString());

            racun = new Racun(stan,lim,ime, priimek);
        }
    }
}
