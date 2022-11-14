namespace Racuni
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ustvari = new System.Windows.Forms.Button();
            this.poslovnigroup = new System.Windows.Forms.GroupBox();
            this.imePodjetja = new System.Windows.Forms.TextBox();
            this.DNOradio = new System.Windows.Forms.RadioButton();
            this.DOOradio = new System.Windows.Forms.RadioButton();
            this.DDradio = new System.Windows.Forms.RadioButton();
            this.SPradio = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.valutnigroup = new System.Windows.Forms.GroupBox();
            this.primarnaValuta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dodajvaluto = new System.Windows.Forms.Button();
            this.valutaText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.valuteListbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vrsteRačunov = new System.Windows.Forms.ComboBox();
            this.osebnigroup = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.obrestnameraText = new System.Windows.Forms.TextBox();
            this.varčevalnicCheckbox = new System.Windows.Forms.CheckBox();
            this.limit = new System.Windows.Forms.TextBox();
            this.stanje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imepriimek = new System.Windows.Forms.TextBox();
            this.DvigGroup = new System.Windows.Forms.GroupBox();
            this.dvigButton = new System.Windows.Forms.Button();
            this.znesekDvig = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PologGroup = new System.Windows.Forms.GroupBox();
            this.pologButton = new System.Windows.Forms.Button();
            this.znesekPolog = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.OsebniRacun = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.povečajButton = new System.Windows.Forms.Button();
            this.prihranekButton = new System.Windows.Forms.Button();
            this.povpStanje = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ValutniRacun = new System.Windows.Forms.GroupBox();
            this.zamenjajValuto = new System.Windows.Forms.Button();
            this.menjajText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PoslovniRacun = new System.Windows.Forms.GroupBox();
            this.likvidno = new System.Windows.Forms.Button();
            this.PoUstvari = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.poslovnigroup.SuspendLayout();
            this.valutnigroup.SuspendLayout();
            this.osebnigroup.SuspendLayout();
            this.DvigGroup.SuspendLayout();
            this.PologGroup.SuspendLayout();
            this.OsebniRacun.SuspendLayout();
            this.ValutniRacun.SuspendLayout();
            this.PoslovniRacun.SuspendLayout();
            this.PoUstvari.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ustvari);
            this.groupBox1.Controls.Add(this.poslovnigroup);
            this.groupBox1.Controls.Add(this.valutnigroup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.vrsteRačunov);
            this.groupBox1.Controls.Add(this.osebnigroup);
            this.groupBox1.Controls.Add(this.limit);
            this.groupBox1.Controls.Add(this.stanje);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.imepriimek);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(250, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustvari Račun";
            // 
            // ustvari
            // 
            this.ustvari.Location = new System.Drawing.Point(190, 386);
            this.ustvari.Margin = new System.Windows.Forms.Padding(2);
            this.ustvari.Name = "ustvari";
            this.ustvari.Size = new System.Drawing.Size(56, 27);
            this.ustvari.TabIndex = 11;
            this.ustvari.Text = "Ustvari";
            this.ustvari.UseVisualStyleBackColor = true;
            this.ustvari.Click += new System.EventHandler(this.ustvari_Click);
            // 
            // poslovnigroup
            // 
            this.poslovnigroup.Controls.Add(this.imePodjetja);
            this.poslovnigroup.Controls.Add(this.DNOradio);
            this.poslovnigroup.Controls.Add(this.DOOradio);
            this.poslovnigroup.Controls.Add(this.DDradio);
            this.poslovnigroup.Controls.Add(this.SPradio);
            this.poslovnigroup.Controls.Add(this.label10);
            this.poslovnigroup.Controls.Add(this.label9);
            this.poslovnigroup.Location = new System.Drawing.Point(4, 261);
            this.poslovnigroup.Margin = new System.Windows.Forms.Padding(2);
            this.poslovnigroup.Name = "poslovnigroup";
            this.poslovnigroup.Padding = new System.Windows.Forms.Padding(2);
            this.poslovnigroup.Size = new System.Drawing.Size(242, 103);
            this.poslovnigroup.TabIndex = 10;
            this.poslovnigroup.TabStop = false;
            this.poslovnigroup.Text = "Poslovni račun";
            // 
            // imePodjetja
            // 
            this.imePodjetja.Location = new System.Drawing.Point(90, 15);
            this.imePodjetja.Margin = new System.Windows.Forms.Padding(2);
            this.imePodjetja.Name = "imePodjetja";
            this.imePodjetja.Size = new System.Drawing.Size(122, 20);
            this.imePodjetja.TabIndex = 6;
            // 
            // DNOradio
            // 
            this.DNOradio.AutoSize = true;
            this.DNOradio.Location = new System.Drawing.Point(161, 67);
            this.DNOradio.Margin = new System.Windows.Forms.Padding(2);
            this.DNOradio.Name = "DNOradio";
            this.DNOradio.Size = new System.Drawing.Size(58, 19);
            this.DNOradio.TabIndex = 5;
            this.DNOradio.TabStop = true;
            this.DNOradio.Text = "d.n.o.";
            this.DNOradio.UseVisualStyleBackColor = true;
            // 
            // DOOradio
            // 
            this.DOOradio.AutoSize = true;
            this.DOOradio.Location = new System.Drawing.Point(161, 39);
            this.DOOradio.Margin = new System.Windows.Forms.Padding(2);
            this.DOOradio.Name = "DOOradio";
            this.DOOradio.Size = new System.Drawing.Size(58, 19);
            this.DOOradio.TabIndex = 4;
            this.DOOradio.TabStop = true;
            this.DOOradio.Text = "d.o.o.";
            this.DOOradio.UseVisualStyleBackColor = true;
            // 
            // DDradio
            // 
            this.DDradio.AutoSize = true;
            this.DDradio.Location = new System.Drawing.Point(90, 67);
            this.DDradio.Margin = new System.Windows.Forms.Padding(2);
            this.DDradio.Name = "DDradio";
            this.DDradio.Size = new System.Drawing.Size(48, 19);
            this.DDradio.TabIndex = 3;
            this.DDradio.TabStop = true;
            this.DDradio.Text = "d.d.";
            this.DDradio.UseVisualStyleBackColor = true;
            // 
            // SPradio
            // 
            this.SPradio.AutoSize = true;
            this.SPradio.Location = new System.Drawing.Point(90, 39);
            this.SPradio.Margin = new System.Windows.Forms.Padding(2);
            this.SPradio.Name = "SPradio";
            this.SPradio.Size = new System.Drawing.Size(44, 19);
            this.SPradio.TabIndex = 2;
            this.SPradio.TabStop = true;
            this.SPradio.Text = "s.p";
            this.SPradio.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tip podjetja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Naziv podjetja";
            // 
            // valutnigroup
            // 
            this.valutnigroup.Controls.Add(this.primarnaValuta);
            this.valutnigroup.Controls.Add(this.label8);
            this.valutnigroup.Controls.Add(this.dodajvaluto);
            this.valutnigroup.Controls.Add(this.valutaText);
            this.valutnigroup.Controls.Add(this.label7);
            this.valutnigroup.Controls.Add(this.label6);
            this.valutnigroup.Controls.Add(this.valuteListbox);
            this.valutnigroup.Location = new System.Drawing.Point(4, 145);
            this.valutnigroup.Margin = new System.Windows.Forms.Padding(2);
            this.valutnigroup.Name = "valutnigroup";
            this.valutnigroup.Padding = new System.Windows.Forms.Padding(2);
            this.valutnigroup.Size = new System.Drawing.Size(242, 110);
            this.valutnigroup.TabIndex = 9;
            this.valutnigroup.TabStop = false;
            this.valutnigroup.Text = "Valutni račun";
            // 
            // primarnaValuta
            // 
            this.primarnaValuta.FormattingEnabled = true;
            this.primarnaValuta.Location = new System.Drawing.Point(129, 85);
            this.primarnaValuta.Margin = new System.Windows.Forms.Padding(2);
            this.primarnaValuta.Name = "primarnaValuta";
            this.primarnaValuta.Size = new System.Drawing.Size(99, 21);
            this.primarnaValuta.TabIndex = 10;
            this.primarnaValuta.SelectedIndexChanged += new System.EventHandler(this.primarnaValuta_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Primarna valuta";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dodajvaluto
            // 
            this.dodajvaluto.Location = new System.Drawing.Point(124, 43);
            this.dodajvaluto.Margin = new System.Windows.Forms.Padding(2);
            this.dodajvaluto.Name = "dodajvaluto";
            this.dodajvaluto.Size = new System.Drawing.Size(114, 25);
            this.dodajvaluto.TabIndex = 8;
            this.dodajvaluto.Text = "Dodaj na seznam";
            this.dodajvaluto.UseVisualStyleBackColor = true;
            this.dodajvaluto.Click += new System.EventHandler(this.dodajvaluto_Click);
            // 
            // valutaText
            // 
            this.valutaText.Location = new System.Drawing.Point(165, 19);
            this.valutaText.Margin = new System.Windows.Forms.Padding(2);
            this.valutaText.Name = "valutaText";
            this.valutaText.Size = new System.Drawing.Size(68, 20);
            this.valutaText.TabIndex = 7;
            this.valutaText.TextChanged += new System.EventHandler(this.valutaText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valuta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Seznam valut";
            // 
            // valuteListbox
            // 
            this.valuteListbox.FormattingEnabled = true;
            this.valuteListbox.Location = new System.Drawing.Point(4, 37);
            this.valuteListbox.Margin = new System.Windows.Forms.Padding(2);
            this.valuteListbox.Name = "valuteListbox";
            this.valuteListbox.Size = new System.Drawing.Size(91, 69);
            this.valuteListbox.TabIndex = 0;
            this.valuteListbox.SelectedIndexChanged += new System.EventHandler(this.valuteListbox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vrsta računa";
            // 
            // vrsteRačunov
            // 
            this.vrsteRačunov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vrsteRačunov.FormattingEnabled = true;
            this.vrsteRačunov.Items.AddRange(new object[] {
            "Osebni račun",
            "Valutni račun",
            "Poslovni račun"});
            this.vrsteRačunov.Location = new System.Drawing.Point(80, 68);
            this.vrsteRačunov.Margin = new System.Windows.Forms.Padding(2);
            this.vrsteRačunov.Name = "vrsteRačunov";
            this.vrsteRačunov.Size = new System.Drawing.Size(166, 21);
            this.vrsteRačunov.TabIndex = 7;
            this.vrsteRačunov.SelectedIndexChanged += new System.EventHandler(this.vrsteRačunov_SelectedIndexChanged);
            // 
            // osebnigroup
            // 
            this.osebnigroup.Controls.Add(this.label11);
            this.osebnigroup.Controls.Add(this.label4);
            this.osebnigroup.Controls.Add(this.obrestnameraText);
            this.osebnigroup.Controls.Add(this.varčevalnicCheckbox);
            this.osebnigroup.Location = new System.Drawing.Point(4, 93);
            this.osebnigroup.Margin = new System.Windows.Forms.Padding(2);
            this.osebnigroup.Name = "osebnigroup";
            this.osebnigroup.Padding = new System.Windows.Forms.Padding(2);
            this.osebnigroup.Size = new System.Drawing.Size(242, 47);
            this.osebnigroup.TabIndex = 6;
            this.osebnigroup.TabStop = false;
            this.osebnigroup.Text = "Osebni Račun";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(227, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "%";
            this.label11.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oberstna mera";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // obrestnameraText
            // 
            this.obrestnameraText.Location = new System.Drawing.Point(179, 19);
            this.obrestnameraText.Margin = new System.Windows.Forms.Padding(2);
            this.obrestnameraText.Name = "obrestnameraText";
            this.obrestnameraText.Size = new System.Drawing.Size(42, 20);
            this.obrestnameraText.TabIndex = 6;
            this.obrestnameraText.TextChanged += new System.EventHandler(this.obrestnameraText_TextChanged);
            this.obrestnameraText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stanje_KeyPress);
            // 
            // varčevalnicCheckbox
            // 
            this.varčevalnicCheckbox.AutoSize = true;
            this.varčevalnicCheckbox.Location = new System.Drawing.Point(6, 20);
            this.varčevalnicCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.varčevalnicCheckbox.Name = "varčevalnicCheckbox";
            this.varčevalnicCheckbox.Size = new System.Drawing.Size(85, 19);
            this.varčevalnicCheckbox.TabIndex = 0;
            this.varčevalnicCheckbox.Text = "Varčevalni";
            this.varčevalnicCheckbox.UseVisualStyleBackColor = true;
            // 
            // limit
            // 
            this.limit.Location = new System.Drawing.Point(165, 42);
            this.limit.Margin = new System.Windows.Forms.Padding(2);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(81, 20);
            this.limit.TabIndex = 5;
            this.limit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stanje_KeyPress);
            // 
            // stanje
            // 
            this.stanje.Location = new System.Drawing.Point(46, 42);
            this.stanje.Margin = new System.Windows.Forms.Padding(2);
            this.stanje.Name = "stanje";
            this.stanje.Size = new System.Drawing.Size(75, 20);
            this.stanje.TabIndex = 4;
            this.stanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stanje_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stanje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime in Priimek";
            // 
            // imepriimek
            // 
            this.imepriimek.Location = new System.Drawing.Point(98, 17);
            this.imepriimek.Margin = new System.Windows.Forms.Padding(2);
            this.imepriimek.Name = "imepriimek";
            this.imepriimek.Size = new System.Drawing.Size(148, 20);
            this.imepriimek.TabIndex = 0;
            // 
            // DvigGroup
            // 
            this.DvigGroup.Controls.Add(this.dvigButton);
            this.DvigGroup.Controls.Add(this.znesekDvig);
            this.DvigGroup.Controls.Add(this.label12);
            this.DvigGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DvigGroup.Location = new System.Drawing.Point(5, 27);
            this.DvigGroup.Margin = new System.Windows.Forms.Padding(2);
            this.DvigGroup.Name = "DvigGroup";
            this.DvigGroup.Padding = new System.Windows.Forms.Padding(2);
            this.DvigGroup.Size = new System.Drawing.Size(159, 75);
            this.DvigGroup.TabIndex = 2;
            this.DvigGroup.TabStop = false;
            this.DvigGroup.Text = "Dvig";
            // 
            // dvigButton
            // 
            this.dvigButton.Location = new System.Drawing.Point(99, 49);
            this.dvigButton.Margin = new System.Windows.Forms.Padding(2);
            this.dvigButton.Name = "dvigButton";
            this.dvigButton.Size = new System.Drawing.Size(56, 26);
            this.dvigButton.TabIndex = 2;
            this.dvigButton.Text = "Dvig";
            this.dvigButton.UseVisualStyleBackColor = true;
            this.dvigButton.Click += new System.EventHandler(this.dvigButton_Click);
            // 
            // znesekDvig
            // 
            this.znesekDvig.Location = new System.Drawing.Point(47, 18);
            this.znesekDvig.Margin = new System.Windows.Forms.Padding(2);
            this.znesekDvig.Name = "znesekDvig";
            this.znesekDvig.Size = new System.Drawing.Size(107, 23);
            this.znesekDvig.TabIndex = 1;
            this.znesekDvig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stanje_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Znesek";
            // 
            // PologGroup
            // 
            this.PologGroup.Controls.Add(this.pologButton);
            this.PologGroup.Controls.Add(this.znesekPolog);
            this.PologGroup.Controls.Add(this.label13);
            this.PologGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PologGroup.Location = new System.Drawing.Point(5, 106);
            this.PologGroup.Margin = new System.Windows.Forms.Padding(2);
            this.PologGroup.Name = "PologGroup";
            this.PologGroup.Padding = new System.Windows.Forms.Padding(2);
            this.PologGroup.Size = new System.Drawing.Size(159, 77);
            this.PologGroup.TabIndex = 3;
            this.PologGroup.TabStop = false;
            this.PologGroup.Text = "Polog";
            // 
            // pologButton
            // 
            this.pologButton.Location = new System.Drawing.Point(98, 45);
            this.pologButton.Margin = new System.Windows.Forms.Padding(2);
            this.pologButton.Name = "pologButton";
            this.pologButton.Size = new System.Drawing.Size(56, 30);
            this.pologButton.TabIndex = 2;
            this.pologButton.Text = "Polog";
            this.pologButton.UseVisualStyleBackColor = true;
            this.pologButton.Click += new System.EventHandler(this.pologButton_Click);
            // 
            // znesekPolog
            // 
            this.znesekPolog.Location = new System.Drawing.Point(47, 18);
            this.znesekPolog.Margin = new System.Windows.Forms.Padding(2);
            this.znesekPolog.Name = "znesekPolog";
            this.znesekPolog.Size = new System.Drawing.Size(107, 23);
            this.znesekPolog.TabIndex = 1;
            this.znesekPolog.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.znesekPolog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stanje_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Znesek";
            // 
            // OsebniRacun
            // 
            this.OsebniRacun.Controls.Add(this.label15);
            this.OsebniRacun.Controls.Add(this.povečajButton);
            this.OsebniRacun.Controls.Add(this.prihranekButton);
            this.OsebniRacun.Controls.Add(this.povpStanje);
            this.OsebniRacun.Controls.Add(this.label14);
            this.OsebniRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsebniRacun.Location = new System.Drawing.Point(5, 179);
            this.OsebniRacun.Margin = new System.Windows.Forms.Padding(2);
            this.OsebniRacun.Name = "OsebniRacun";
            this.OsebniRacun.Padding = new System.Windows.Forms.Padding(2);
            this.OsebniRacun.Size = new System.Drawing.Size(159, 94);
            this.OsebniRacun.TabIndex = 4;
            this.OsebniRacun.TabStop = false;
            this.OsebniRacun.Text = "Osebni račun";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 71);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Obr. mera";
            // 
            // povečajButton
            // 
            this.povečajButton.Location = new System.Drawing.Point(80, 63);
            this.povečajButton.Margin = new System.Windows.Forms.Padding(2);
            this.povečajButton.Name = "povečajButton";
            this.povečajButton.Size = new System.Drawing.Size(73, 25);
            this.povečajButton.TabIndex = 3;
            this.povečajButton.Text = "Povečaj";
            this.povečajButton.UseVisualStyleBackColor = true;
            this.povečajButton.Click += new System.EventHandler(this.povečajButton_Click);
            // 
            // prihranekButton
            // 
            this.prihranekButton.Location = new System.Drawing.Point(80, 35);
            this.prihranekButton.Margin = new System.Windows.Forms.Padding(2);
            this.prihranekButton.Name = "prihranekButton";
            this.prihranekButton.Size = new System.Drawing.Size(73, 24);
            this.prihranekButton.TabIndex = 2;
            this.prihranekButton.Text = "Prihranek";
            this.prihranekButton.UseVisualStyleBackColor = true;
            this.prihranekButton.Click += new System.EventHandler(this.prihranekButton_Click);
            // 
            // povpStanje
            // 
            this.povpStanje.Location = new System.Drawing.Point(7, 36);
            this.povpStanje.Margin = new System.Windows.Forms.Padding(2);
            this.povpStanje.Name = "povpStanje";
            this.povpStanje.Size = new System.Drawing.Size(69, 23);
            this.povpStanje.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Povp. mesečno stanje";
            // 
            // ValutniRacun
            // 
            this.ValutniRacun.Controls.Add(this.zamenjajValuto);
            this.ValutniRacun.Controls.Add(this.menjajText);
            this.ValutniRacun.Controls.Add(this.label16);
            this.ValutniRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValutniRacun.Location = new System.Drawing.Point(5, 277);
            this.ValutniRacun.Margin = new System.Windows.Forms.Padding(2);
            this.ValutniRacun.Name = "ValutniRacun";
            this.ValutniRacun.Padding = new System.Windows.Forms.Padding(2);
            this.ValutniRacun.Size = new System.Drawing.Size(159, 69);
            this.ValutniRacun.TabIndex = 5;
            this.ValutniRacun.TabStop = false;
            this.ValutniRacun.Text = "Valutni račun";
            // 
            // zamenjajValuto
            // 
            this.zamenjajValuto.Location = new System.Drawing.Point(58, 37);
            this.zamenjajValuto.Margin = new System.Windows.Forms.Padding(2);
            this.zamenjajValuto.Name = "zamenjajValuto";
            this.zamenjajValuto.Size = new System.Drawing.Size(101, 28);
            this.zamenjajValuto.TabIndex = 2;
            this.zamenjajValuto.Text = "Zamenjaj valuto";
            this.zamenjajValuto.UseVisualStyleBackColor = true;
            this.zamenjajValuto.Click += new System.EventHandler(this.zamenjajValuto_Click);
            // 
            // menjajText
            // 
            this.menjajText.Location = new System.Drawing.Point(4, 40);
            this.menjajText.Margin = new System.Windows.Forms.Padding(2);
            this.menjajText.Name = "menjajText";
            this.menjajText.Size = new System.Drawing.Size(50, 23);
            this.menjajText.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Menjalni tečaj";
            // 
            // PoslovniRacun
            // 
            this.PoslovniRacun.Controls.Add(this.likvidno);
            this.PoslovniRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoslovniRacun.Location = new System.Drawing.Point(5, 364);
            this.PoslovniRacun.Margin = new System.Windows.Forms.Padding(2);
            this.PoslovniRacun.Name = "PoslovniRacun";
            this.PoslovniRacun.Padding = new System.Windows.Forms.Padding(2);
            this.PoslovniRacun.Size = new System.Drawing.Size(159, 52);
            this.PoslovniRacun.TabIndex = 3;
            this.PoslovniRacun.TabStop = false;
            this.PoslovniRacun.Text = "Poslovni račun";
            // 
            // likvidno
            // 
            this.likvidno.Location = new System.Drawing.Point(14, 21);
            this.likvidno.Margin = new System.Windows.Forms.Padding(2);
            this.likvidno.Name = "likvidno";
            this.likvidno.Size = new System.Drawing.Size(139, 27);
            this.likvidno.TabIndex = 2;
            this.likvidno.Text = "Podjetje Likvidno?";
            this.likvidno.UseVisualStyleBackColor = true;
            this.likvidno.Click += new System.EventHandler(this.likvidno_Click);
            // 
            // PoUstvari
            // 
            this.PoUstvari.Controls.Add(this.DvigGroup);
            this.PoUstvari.Controls.Add(this.PoslovniRacun);
            this.PoUstvari.Controls.Add(this.PologGroup);
            this.PoUstvari.Controls.Add(this.ValutniRacun);
            this.PoUstvari.Controls.Add(this.OsebniRacun);
            this.PoUstvari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoUstvari.Location = new System.Drawing.Point(265, 12);
            this.PoUstvari.Name = "PoUstvari";
            this.PoUstvari.Size = new System.Drawing.Size(190, 421);
            this.PoUstvari.TabIndex = 6;
            this.PoUstvari.TabStop = false;
            this.PoUstvari.Text = "Stanje: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 445);
            this.Controls.Add(this.PoUstvari);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.poslovnigroup.ResumeLayout(false);
            this.poslovnigroup.PerformLayout();
            this.valutnigroup.ResumeLayout(false);
            this.valutnigroup.PerformLayout();
            this.osebnigroup.ResumeLayout(false);
            this.osebnigroup.PerformLayout();
            this.DvigGroup.ResumeLayout(false);
            this.DvigGroup.PerformLayout();
            this.PologGroup.ResumeLayout(false);
            this.PologGroup.PerformLayout();
            this.OsebniRacun.ResumeLayout(false);
            this.OsebniRacun.PerformLayout();
            this.ValutniRacun.ResumeLayout(false);
            this.ValutniRacun.PerformLayout();
            this.PoslovniRacun.ResumeLayout(false);
            this.PoUstvari.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox imepriimek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox limit;
        private System.Windows.Forms.TextBox stanje;
        private System.Windows.Forms.GroupBox osebnigroup;
        private System.Windows.Forms.CheckBox varčevalnicCheckbox;
        private System.Windows.Forms.TextBox obrestnameraText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vrsteRačunov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox valutnigroup;
        private System.Windows.Forms.ListBox valuteListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox valutaText;
        private System.Windows.Forms.Button dodajvaluto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox primarnaValuta;
        private System.Windows.Forms.GroupBox poslovnigroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton SPradio;
        private System.Windows.Forms.RadioButton DDradio;
        private System.Windows.Forms.RadioButton DOOradio;
        private System.Windows.Forms.RadioButton DNOradio;
        private System.Windows.Forms.TextBox imePodjetja;
        private System.Windows.Forms.Button ustvari;
        private System.Windows.Forms.GroupBox DvigGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox znesekDvig;
        private System.Windows.Forms.Button dvigButton;
        private System.Windows.Forms.GroupBox PologGroup;
        private System.Windows.Forms.Button pologButton;
        private System.Windows.Forms.TextBox znesekPolog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox OsebniRacun;
        private System.Windows.Forms.Button prihranekButton;
        private System.Windows.Forms.TextBox povpStanje;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button povečajButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox ValutniRacun;
        private System.Windows.Forms.Button zamenjajValuto;
        private System.Windows.Forms.TextBox menjajText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox PoslovniRacun;
        private System.Windows.Forms.Button likvidno;
        private System.Windows.Forms.GroupBox PoUstvari;
        private System.Windows.Forms.Label label11;
    }
}

