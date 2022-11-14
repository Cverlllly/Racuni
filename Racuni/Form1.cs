using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Racuni
{
    public partial class Form1 : Form
    {
        Racun racun;
       
        public Form1()
        {
            racun = new ValutniRacun();
            InitializeComponent();
            PoUstvari.Enabled = false;
            ustvari.Enabled = false;
            stanje.Text = 0.ToString();
            limit.Text = 10.ToString();
            znesekDvig.Text = 0.ToString();
            znesekPolog.Text = 0.ToString();
            povpStanje.Text = 0.ToString();
            obrestnameraText.Text = 0.ToString();
            if(racun is ValutniRacun)
            {
                foreach (string x in (racun as ValutniRacun).SeznamValut)
                {
                    valuteListbox.Items.Add(x);
                }
                foreach (string x in (racun as ValutniRacun).SeznamValut)
                {
                    primarnaValuta.Items.Add(x);
                }
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
                    racun = new OsebniRacun();
                }
                else if (pregled == "Poslovni račun")
                {
                    poslovnigroup.Enabled = true;
                    valutnigroup.Enabled = false;
                    osebnigroup.Enabled = false;
                    racun = new PoslovniRacun();
                }
                else if (pregled == "Valutni račun")
                {
                    valutnigroup.Enabled = true;
                    poslovnigroup.Enabled = false;
                    osebnigroup.Enabled = false;
                    racun = new ValutniRacun();
                }
            }
            
        }
        private void ustvari_Click(object sender, EventArgs e)
        {
            try
            {

                int prev = 0;
                var neki = imepriimek.Text.Split();
                var stan = Convert.ToDouble(stanje.Text);
                var lim = Convert.ToDouble(limit.Text);
                var obrest = Convert.ToDouble(obrestnameraText.Text) / 100;
                var naz = imePodjetja.Text;
                var ime = "";
                var priimek = "";
                if (neki.Count() < 2)
                {
                    MessageBox.Show("Preverite vnos imena ali priimka","Napaka",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    ime = neki[0];
                    priimek= neki[1];
                    prev= 1;
                    racun = new Racun(stan, lim, ime, priimek);
                }
                if (prev == 1)
                {
                    MessageBox.Show("Račun je bil uspešno ustvarjen");
                    groupBox1.Enabled = false;
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
                            racun=new OsebniRacun(stan, lim, ime, priimek, true, obrest);
                        }
                        else
                        {
                            racun = new OsebniRacun(stan, lim, ime, priimek, false, obrest);

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

                        racun = new PoslovniRacun(stan, lim, ime, priimek, naz, tip);
                    }
                    else if (pregled == "Valutni račun")
                    {
                        if (valuteListbox.SelectedIndex.ToString()==string.Empty)
                        {
                            MessageBox.Show("Napaka");
                        }
                        else
                        {
                            var valuta = valuteListbox.SelectedItem.ToString();
                            PoUstvari.Enabled = true;
                            DvigGroup.Enabled = true;
                            PologGroup.Enabled = true;
                            OsebniRacun.Enabled = false;
                            PoslovniRacun.Enabled = false;
                            ValutniRacun.Enabled = true;
                            racun = new ValutniRacun(stan, lim, ime, priimek, valuta);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Račun ni bil ustvarjen");
                }
                label15.Text = obrestnameraText.Text;

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

            MessageBox.Show("Vaš letni prihranek je " + (racun as OsebniRacun).LetniPrihranek(Convert.ToDouble(povpStanje.Text)).ToString()+"€", "Letni Prihranek", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if ((racun as OsebniRacun).obrestnaMera <= 0)
            {
                (racun as OsebniRacun).obrestnaMera = 0.05;
                (racun as OsebniRacun).NastaviObrestnoMero();
                double a = Math.Round((racun as OsebniRacun).obrestnaMera * 100, 2);
                label15.Text = a.ToString() + "%";
            }
            else
            {
                (racun as OsebniRacun).NastaviObrestnoMero();
                double a = Math.Round((racun as OsebniRacun).obrestnaMera * 100, 2);
                label15.Text = a.ToString() + "%";
            }
            
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
                if(racun is ValutniRacun)
                {
                    (racun as ValutniRacun).SeznamValut.Add(dodaj);
                    valuteListbox.Items.Clear();
                    foreach (string x in (racun as ValutniRacun).SeznamValut)
                    {
                        valuteListbox.Items.Add(x);
                    }
                    primarnaValuta.Items.Clear();
                    foreach (string x in (racun as ValutniRacun).SeznamValut)
                    {
                        primarnaValuta.Items.Add(x);
                    }
                }

            }

            
        }

        private void primarnaValuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuteListbox.SelectedItem = primarnaValuta.SelectedItem;
            
        }

        private void zamenjajValuto_Click(object sender, EventArgs e)
        {
            menjajText.Text.Replace(".", ",");
            double menjaj = Convert.ToDouble(menjajText.Text);
            if(menjajText.Text == string.Empty)
            {
                MessageBox.Show("Polje za dodajanje je prazno", "Prazno polje", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                
                PoUstvari.Text = ("Stanje: "+ (racun as ValutniRacun).zamenjajValuto(menjaj)).ToString(); //preveri, katerega tipa je -> if(racun is ValutniRacun) ...
                // (racun as ValutniRacun).
            }
            
        }

        private void likvidno_Click(object sender, EventArgs e)
        {
            if ((racun as PoslovniRacun).Likvidno() == true)
            {
                MessageBox.Show("Račun je likviden", "Likvidnost", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Račun ni likviden", "Likvidnost", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void valutaText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
