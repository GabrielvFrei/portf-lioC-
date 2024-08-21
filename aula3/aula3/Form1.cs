namespace aula3
{
    public partial class Form1 : Form
    {
        string desconto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            desconto = "vista";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vPreco = 0;
            double vPrecoDes = 0;
            vPreco = double.Parse(vPrecotxt.Text);
            if (desconto == "debito")
            {
                resultadotxt.Text = "" + vPreco;
            }
            if (desconto == "credito")
            {
                vPrecoDes = vPreco * 15 / 100;
                resultadotxt.Text = "" + (vPreco + vPrecoDes);
            }
            if (desconto == "vista")
            {
                vPrecoDes = vPreco * 30 / 100;
                resultadotxt.Text = "" + (vPreco + vPrecoDes);
            }
        }

        private void debito_CheckedChanged(object sender, EventArgs e)
        {
            desconto = "debito";
        }

        private void credito_CheckedChanged(object sender, EventArgs e)
        {
            desconto = "credíto";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
