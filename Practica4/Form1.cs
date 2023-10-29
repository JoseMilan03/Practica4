namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = int.Parse(this.a.Text);
            b = int.Parse(this.b.Text);
            c = int.Parse(this.c.Text);
            d = int.Parse(this.d.Text);

            textBox5.Text = d.ToString();
            textBox6.Text = c.ToString();
            textBox7.Text = b.ToString();
            textBox8.Text = a.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}