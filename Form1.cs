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

        private void receiptButton_Click(object sender, EventArgs e)
        {

            String s1 = "Thank you for shopping\n Customer receipt:";
            String s2 = "Customer reference number: " + cusRefText.Text;
            String s3 = "**********************************************";
            String s4 = "Name :" + nameText.Text + " " + surText.Text;
            String s5 = "Red candle: " + redCount.Value.ToString();
            String s6 = "Blue candle: " + blueCount.Value.ToString();
            String s7 = "Yellow candle: " + yellowCount.Value.ToString();
            String s8 = "Green candle: " + greenCount.Value.ToString();
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++
            String s9 = "Tax: R" + taxLab.Text;
            String s10 = "Subtotal: R" + subLab.Text;
            String s11 = "Net total: R" + netLab.Text;
            String s12 = "Date: " + DateOnly.FromDayNumber;

            listBox1.Text = s1 + "\n" + s2 + "\n" + s3 + "\n" + s4 + "\n" + s5 + "\n" + s6 + "\n" + s7 + "\n" + s3 + "\n" + s9 + "\n" + s10 + "\n" + s11 + "\n" + s12;
            //  listBox1.Text = "Thank you for shopping\n Customer receipt:";
        }

        private void cusRefText_TextChanged(object sender, EventArgs e)
        {
            cusRefText.Text = nameText.Text.Substring(0,2) + surText.Text.Substring (0,2);
        }
    }
}