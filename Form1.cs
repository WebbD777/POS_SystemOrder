namespace POS_SystemOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int extraCandle = 1;
            if (scentButton.Checked)
            {
                extraCandle = 1;
            }
            else if (nScentButton.Checked)
            {
                extraCandle = 2;
            }

            double redNum = Decimal.ToDouble(redCount.Value * extraCandle);
            double blueNum = Decimal.ToDouble(blueCount.Value * extraCandle);
            double yellowNum = Decimal.ToDouble(yellowCount.Value * extraCandle);
            double greenNum = Decimal.ToDouble(greenCount.Value * extraCandle);

            double total = redNum + blueNum + yellowNum + greenNum;
            double tax = total * 0.16;
            double subTotal = total - tax;

            taxLab.Text = "R" + tax.ToString();
            subLab.Text = "R" + subTotal.ToString();
            netLab.Text = "R" + total.ToString();

            // taxLab.Text = redCount.Value.ToString();
        }
    }
}