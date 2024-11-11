namespace zadanie_domowe_aplikacja_windows_forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            paczka = new RadioButton();
            list = new RadioButton();
            pocztowka = new RadioButton();
            groupBox2 = new GroupBox();
            TxtBoxMiasto = new TextBox();
            TxtBoxKod = new TextBox();
            TxtBoxUlica = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnSprawdzCene = new Button();
            BtnZatwierdz = new Button();
            LblCena = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(paczka);
            groupBox1.Controls.Add(list);
            groupBox1.Controls.Add(pocztowka);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 128);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj Przesyłki";
            // 
            // paczka
            // 
            paczka.AutoSize = true;
            paczka.Location = new Point(6, 72);
            paczka.Name = "paczka";
            paczka.Size = new Size(61, 19);
            paczka.TabIndex = 2;
            paczka.TabStop = true;
            paczka.Text = "Paczka";
            paczka.UseVisualStyleBackColor = true;
            paczka.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // list
            // 
            list.AutoSize = true;
            list.Location = new Point(6, 47);
            list.Name = "list";
            list.Size = new Size(43, 19);
            list.TabIndex = 1;
            list.TabStop = true;
            list.Text = "List";
            list.TextAlign = ContentAlignment.MiddleCenter;
            list.UseVisualStyleBackColor = true;
            list.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pocztowka
            // 
            pocztowka.AutoSize = true;
            pocztowka.Checked = true;
            pocztowka.Location = new Point(6, 22);
            pocztowka.Name = "pocztowka";
            pocztowka.Size = new Size(82, 19);
            pocztowka.TabIndex = 0;
            pocztowka.TabStop = true;
            pocztowka.Text = "Pocztówka";
            pocztowka.UseVisualStyleBackColor = true;
            pocztowka.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtBoxMiasto);
            groupBox2.Controls.Add(TxtBoxKod);
            groupBox2.Controls.Add(TxtBoxUlica);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(301, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 233);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane Adresowe";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // TxtBoxMiasto
            // 
            TxtBoxMiasto.Location = new Point(23, 157);
            TxtBoxMiasto.Name = "TxtBoxMiasto";
            TxtBoxMiasto.Size = new Size(282, 23);
            TxtBoxMiasto.TabIndex = 5;
            // 
            // TxtBoxKod
            // 
            TxtBoxKod.Location = new Point(23, 103);
            TxtBoxKod.Name = "TxtBoxKod";
            TxtBoxKod.Size = new Size(282, 23);
            TxtBoxKod.TabIndex = 4;
            // 
            // TxtBoxUlica
            // 
            TxtBoxUlica.Location = new Point(23, 49);
            TxtBoxUlica.Name = "TxtBoxUlica";
            TxtBoxUlica.Size = new Size(282, 23);
            TxtBoxUlica.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 134);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 2;
            label5.Text = "Miasto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 80);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 1;
            label4.Text = "Kod pocztowy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 26);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 0;
            label3.Text = "Ulica z numerem";
            // 
            // BtnSprawdzCene
            // 
            BtnSprawdzCene.Location = new Point(12, 151);
            BtnSprawdzCene.Name = "BtnSprawdzCene";
            BtnSprawdzCene.Size = new Size(266, 23);
            BtnSprawdzCene.TabIndex = 2;
            BtnSprawdzCene.Text = "Sprawdź cenę";
            BtnSprawdzCene.UseVisualStyleBackColor = true;
            BtnSprawdzCene.Click += button1_Click;
            // 
            // BtnZatwierdz
            // 
            BtnZatwierdz.Location = new Point(12, 281);
            BtnZatwierdz.Name = "BtnZatwierdz";
            BtnZatwierdz.Size = new Size(612, 23);
            BtnZatwierdz.TabIndex = 3;
            BtnZatwierdz.Text = "Zatwierdź";
            BtnZatwierdz.UseVisualStyleBackColor = true;
            BtnZatwierdz.Click += button2_Click;
            // 
            // LblCena
            // 
            LblCena.AutoSize = true;
            LblCena.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LblCena.Location = new Point(148, 190);
            LblCena.Name = "LblCena";
            LblCena.Size = new Size(66, 25);
            LblCena.TabIndex = 5;
            LblCena.Text = "Cena: ";
            LblCena.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gmail;
            pictureBox1.Location = new Point(18, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 263);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 263);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            label2.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 316);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(LblCena);
            Controls.Add(BtnZatwierdz);
            Controls.Add(BtnSprawdzCene);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nadaj Przesyłkę: PESEL: CEZARY SOBOCIŃSKI";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton paczka;
        private RadioButton list;
        private RadioButton pocztowka;
        private Button BtnSprawdzCene;
        private Button BtnZatwierdz;
        private Label LblCena;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtBoxMiasto;
        private TextBox TxtBoxKod;
        private TextBox TxtBoxUlica;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
