namespace zadanie_domowe_aplikacja_windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int test;
            bool ok = int.TryParse(TxtBoxKod.Text, out test);
            if (TxtBoxKod.Text.Length < 5 || TxtBoxKod.Text.Length > 5)
            {
                MessageBox.Show("Nieprawid�owa liczba cyfr w kodzie pocztowym");
            }
            else if(!ok)
            {
                MessageBox.Show("Kod Pocztowy powinien sk�ada� si� z cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesy�ki zosta�y wprowadzone");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pocztowka.Checked)
            {
                pictureBox1.Image = Properties.Resources.gmail;
                LblCena.Text = "Cena: 1z�";
            }
            else if (list.Checked)
            {
                pictureBox1.Image = Properties.Resources.letter;
                LblCena.Text = "Cena: 1.5z�";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.gift;
                LblCena.Text = "Cena: 10z�";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
