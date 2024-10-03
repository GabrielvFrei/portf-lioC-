namespace aula1POO
{
    public partial class Form1 : Form
    {
        Pessoa p1 = new Pessoa(); //instanciar classe
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            p1.nome = textBox1.Text;
            p1.idade = Convert.ToInt32(textBox2.Text);
            p1.telefone = Convert.ToInt32(textBox3.Text);
            p1.cadastrar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e){ 
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1.exibir();
        }
    }
}
