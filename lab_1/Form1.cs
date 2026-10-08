using System.Text;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string IntegerToBinary(int number)
        {
            if (number == 0) return "0";
            string bits = "";

            while (number > 0)
            {
                bits += number % 2;
                number /= 2;
            }
            return new string(bits.Reverse().ToArray());
        }

        static string FractionToBinary(decimal number)
        {
            string bits = "";

            while (number > 0 && bits.Length < 64)
            {
                number *= 2;
                bits += (int)(number - number % 1);
                number %= 1;
            }
            return bits;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                decimal number = Convert.ToDecimal(textBox1.Text);

                int format = radioButton1.Checked ? 32 : 64;
                int b = radioButton1.Checked ? 8 : 11;

                char sign = number >= 0 ? '0' : '1';
                number = Math.Abs(number);

                int integerPart = (int)number;
                string intBin = IntegerToBinary(integerPart);

                decimal fractionPart = number % 1;
                string fracBin = FractionToBinary(fractionPart);

                int exponent;
                string mantissa;

                if (integerPart != 0)
                {
                    exponent = intBin.Length - 1;
                    mantissa = intBin.Substring(1) + fracBin;
                }
                else
                {
                    int firstOne = fracBin.IndexOf('1');
                    exponent = -(firstOne + 1);
                    mantissa = fracBin.Substring(firstOne + 1);
                }

                int z = (int)Math.Pow(2, b - 1) - 1;
                string exponentBin = IntegerToBinary(exponent + z).PadLeft(b, '0');

                int mantLength = format - b - 1;
                mantissa = mantissa.PadRight(mantLength, '0').Substring(0, mantLength);

                char[] result = new char[format];
                result[0] = sign;

                exponentBin.CopyTo(0, result, 1, b);
                mantissa.CopyTo(0, result, b + 1, mantLength);

                textBox2.Text = new string(result);
                textBox3.Text = sign.ToString();
                textBox4.Text = exponentBin;
                textBox5.Text = mantissa;
                if (fracBin != "")
                    textBox6.Text = intBin + ',' + fracBin;
                else 
                    textBox6.Text = intBin;
            }
            catch 
            {
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox2.Text = "¬ведите дробное число через зап€тую!";
            }
        }
    }
}
