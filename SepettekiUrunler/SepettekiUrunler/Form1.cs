namespace SepettekiUrunler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            int Ceket = 300;
            int Gomlek = 80;
            int Kazak = 100;
            int Pantolon = 120;
            int Fiyat = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.Text=="Ceket")
            {
                label4.Text = Ceket.ToString();
            }

            else if (listBox1.Text == "Gömlek")
            {
                label4.Text = Gomlek.ToString();
            }

            else if (listBox1.Text == "Kazak")
            {
                label4.Text = Kazak.ToString();
            }

            else
            {
                label4.Text = Pantolon.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox2.Items.Add(listBox1.Text + ":" + " " + comboBox1.Text +" " + "Adet");


            if (listBox1.Text=="Ceket")
            {
                label5.Text = Convert.ToInt32(Ceket * Convert.ToInt32(comboBox1.Text)).ToString();
                Fiyat = Fiyat + Convert.ToInt32(label5.Text.ToString());
                label5.Text = Fiyat.ToString();
            
            }

            else if (listBox1.Text == "Gömlek")
            {

                label5.Text = Convert.ToInt32(Gomlek * Convert.ToInt32(comboBox1.Text)).ToString();
                Fiyat = Fiyat + Convert.ToInt32(label5.Text.ToString());
                label5.Text = Fiyat.ToString();
            }

            else if (listBox1.Text == "Kazak")
            {

                label5.Text = Convert.ToInt32(Kazak * Convert.ToInt32(comboBox1.Text)).ToString();
                Fiyat = Fiyat + Convert.ToInt32(label5.Text.ToString());
                label5.Text = Fiyat.ToString();
            }

            else
            {
                label5.Text = Convert.ToInt32(Pantolon * Convert.ToInt32(comboBox1.Text)).ToString();
                Fiyat = Fiyat + Convert.ToInt32(label5.Text.ToString());
                label5.Text = Fiyat.ToString();
            }


        }

    }
}