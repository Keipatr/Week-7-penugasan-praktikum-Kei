namespace Week_7_penugasan_praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            int[] nilaiHuruf = new int[textBoxKalimat.TextLength];
            string[] hasilUbah = new string[textBoxKalimat.TextLength];
            string kalimat = textBoxKalimat.Text.ToUpper();
            char huruf = Convert.ToChar(textBoxHuruf.Text.ToUpper());
            char ubah = Convert.ToChar(textBoxUbah.Text.ToUpper());
            int indexHuruf = char.ToUpper(huruf); 
            int indexUbah = char.ToUpper(ubah);
            int tambahIndex = indexUbah - indexHuruf;
            for (int i = 0; i < kalimat.Length; i++)
            {
                int j = Convert.ToInt32(kalimat[i]);
                if ((j + tambahIndex) > 90)
                {
                    nilaiHuruf[i] = 64 + j + (tambahIndex) - 90;
                }
                else if((j + tambahIndex) < 65)
                {
                    nilaiHuruf[i] = 90 + j + (tambahIndex) - 64;
                }
                else
                {
                    nilaiHuruf[i] = j + (tambahIndex);
                }
            }
            for (int i = 0; i < kalimat.Length; i++)
            {
                hasilUbah[i] += ((char)nilaiHuruf[i]).ToString();
            }
            string output = "";
            for (int i = 0; i < kalimat.Length; i++)
            {
                if (char.IsLetter(Convert.ToChar(hasilUbah[i])))
                {
                    output += hasilUbah[i];
                }
                else
                {
                    output += " ";
                }
            }
                labelOutput.Text = output.ToUpper();            
        }
    }
}