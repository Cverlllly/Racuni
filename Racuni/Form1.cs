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
        OsebniRacun OsRacun;
        ValutniRacun valutniRacun= new ValutniRacun();
        ValutniRacun valRacun;
        PoslovniRacun posRacun;
       
        public Form1()
        {
            InitializeComponent();
            PoUstvari.Enabled = false;
            ustvari.Enabled = false;
            stanje.Text = 0.ToString();
            limit.Text = 10.ToString();
            znesekDvig.Text = 0.ToString();
            znesekPolog.Text = 0.ToString();
            povpStanje.Text = 0.ToString();
            obrestnameraText.Text = 0.ToString();
            foreach (string x in valutniRacun.SeznamValut)
            {
                valuteListbox.Items.Add(x);
            }
            foreach (string x in valutniRacun.SeznamValut)
            {
                primarnaValuta.Items.Add(x);
            }
            primarnaValuta.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pregled = vrsteRačunov.GetItemText(vrsteRačunov.SelectedItem);
            if (pregled == string.Empty)
            {
                poslovnigroup.Enabled = false;
                valutnigroup.Enabled = false;
                osebnigroup.Enabled = false;
                PoUstvari.Enabled = false;
                DvigGroup.Enabled = false;
                PologGroup.Enabled = false;
                OsebniRacun.Enabled = false;
                PoslovniRacun.Enabled = false;
                ValutniRacun.Enabled = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void vrsteRačunov_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox can only be used to select items
            vrsteRačunov.DropDownStyle = ComboBoxStyle.DropDownList;
            string pregled = vrsteRačunov.GetItemText(vrsteRačunov.SelectedItem);
            if (pregled == string.Empty)
            {
                ustvari.Enabled = false;
            }
            else
            {
                ustvari.Enabled = true;
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
            
        }
        private void ustvari_Click(object sender, EventArgs e)
        {
            try
            {
                
                int prev = 1;
                var neki = imepriimek.Text.Split();
                var ime = neki[0];
                var priimek = neki[1];
                var stan = Convert.ToDouble(stanje.Text);
                var lim = Convert.ToDouble(limit.Text);
                var obrest = Convert.ToDouble(obrestnameraText.Text) / 100;
                var naz = imePodjetja.Text;
                racun = new Racun(stan, lim, ime, priimek);
 
                if (prev == 1)
                {
                    MessageBox.Show("Račun je bil uspešno ustvarjen");
                    PoUstvari.Text = "Stanje: " + stan.ToString();
                    string pregled = vrsteRačunov.GetItemText(vrsteRačunov.SelectedItem);
                    if (pregled == "Osebni račun")
                    {
                        PoUstvari.Enabled = true;
                        DvigGroup.Enabled = true;
                        PologGroup.Enabled = true;
                        OsebniRacun.Enabled = true;
                        PoslovniRacun.Enabled = false;
                        ValutniRacun.Enabled = false;
                        if (varčevalnicCheckbox.Checked == true)
                        {
                            OsRacun = new OsebniRacun(stan, lim, ime, priimek, true, obrest);

                        }
                        else
                        {
                            OsRacun = new OsebniRacun(stan, lim, ime, priimek, false, obrest);

                        }             

                    }
                    else if (pregled == "Poslovni račun")
                    {
                        PoUstvari.Enabled = true;
                        DvigGroup.Enabled = true;
                        PologGroup.Enabled = true;
                        OsebniRacun.Enabled = false;
                        PoslovniRacun.Enabled = true;
                        ValutniRacun.Enabled = false;
                        var tip="";
                        if (DDradio.Checked)
                        {
                             tip = DDradio.Text.ToString();
                        }
                        else if (DNOradio.Checked)
                        {
                             tip = DNOradio.Text.ToString();
                        }
                        else if (DOOradio.Checked)
                        {
                             tip = DOOradio.Text.ToString();
                        }
                        else if (SPradio.Checked)
                        {
                             tip=SPradio.Text.ToString();
                        }

                        posRacun = new PoslovniRacun(stan, lim, ime, priimek, naz, tip);
                    }
                    else if (pregled == "Valutni račun")
                    {
                        var valuta = valuteListbox.SelectedItem.ToString();
                        PoUstvari.Enabled = true;
                        DvigGroup.Enabled = true;
                        PologGroup.Enabled = true;
                        OsebniRacun.Enabled = false;
                        PoslovniRacun.Enabled = false;
                        ValutniRacun.Enabled = true;
                        valRacun = new ValutniRacun(stan, lim, ime, priimek, valuta);
                    }
                }
                else
                {
                    MessageBox.Show("Račun ni bil ustvarjen");
                }
                groupBox1.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dvigButton_Click(object sender, EventArgs e)
        {
            string dobis = znesekDvig.Text;
            if (racun.dvig(Convert.ToDouble(dobis)) == false)
            {
                MessageBox.Show("Preverite Limit ali stanje", "Dvig ni bil uspešen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Dvig je bil uspešen", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PoUstvari.Text = "Stanje: " + racun.Stanje;
            }
        }

        private void pologButton_Click(object sender, EventArgs e)
        {
            string das = znesekPolog.Text;
            racun.polog(Convert.ToDouble(das));
            MessageBox.Show("Polog je bil uspešen", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PoUstvari.Text = "Stanje: " + racun.Stanje;
        }

        private void stanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void prihranekButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Vaš letni prihranek je " + OsRacun.LetniPrihranek(Convert.ToDouble(povpStanje.Text)).ToString()+"€", "Letni Prihranek", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void obrestnameraText_TextChanged(object sender, EventArgs e)
        {

        }

        private void valuteListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            primarnaValuta.SelectedItem = valuteListbox.SelectedItem;

        }

        private void povečajButton_Click(object sender, EventArgs e)
        {
            OsRacun.NastaviObrestnoMero();
            double a = Math.Round( OsRacun.obrestnaMera * 100,2);
            
            label15.Text = a.ToString()+"%";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dodajvaluto_Click(object sender, EventArgs e)
        {
            var dodaj = valutaText.Text;
            if(dodaj == string.Empty)
            {
                MessageBox.Show("Polje za dodajanje je prazno", "Prazno polje", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                valutniRacun.SeznamValut.Add(dodaj);
                valuteListbox.Items.Clear();
                foreach (string x in valutniRacun.SeznamValut)
                {
                    valuteListbox.Items.Add(x);
                }
                primarnaValuta.Items.Clear();
                foreach (string x in valutniRacun.SeznamValut)
                {
                    primarnaValuta.Items.Add(x);
                }
            }

            
        }

        private void primarnaValuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuteListbox.SelectedItem = primarnaValuta.SelectedItem;
            
        }

        private void zamenjajValuto_Click(object sender, EventArgs e)
        {
           double menjaj = Convert.ToDouble(menjajText.Text);
            if(menjajText.Text == string.Empty)
            {
                MessageBox.Show("Polje za dodajanje je prazno", "Prazno polje", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                
                PoUstvari.Text = ("Stanje: "+valRacun.zamenjajValuto(menjaj)).ToString();
            }
            
        }

        private void likvidno_Click(object sender, EventArgs e)
        {
            if (posRacun.Likvidno() == true)
            {
                MessageBox.Show("Račun je likviden", "Likvidnost", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Račun ni likviden", "Likvidnost", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
