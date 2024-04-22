namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "0-20 aralığında kitap alana %20 indirim\n" +
                          "21-40 aralığında kitap alana %40 indirim\n" +
                          "41++ aralığında kitap alana %50 indirim\n";
            label2.Text = "Kitap fiyatları sabit ve 8 TL'dir.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double toplam;
            adet=Convert.ToInt32(textBox1.Text);
            toplam = 8 * adet;
            if(adet>0 && adet<=20)
            {
                toplam = (toplam * 80) / 100;
            }
            else if(adet>=21 && adet<41)
            {
                toplam = (toplam * 60) / 100;
            }
            else
            {
                toplam = (toplam * 50) / 100;
            }
            label6.Text=toplam+" TL";
        }
    }
}
