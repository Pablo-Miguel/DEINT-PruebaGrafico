namespace DEINT_PruebaGrafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("Hola, aquí tienes tu mensaje");
            form2.ShowDialog();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value == 100)
            {
                toolStripProgressBar1.Value = 0;
            }
            else 
            {
                toolStripProgressBar1.Increment(100);
                toolStripStatusLabel1.Text = "Cargando limones...";
            }
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, aquí tienes tu mensaje");
        }
    }
}