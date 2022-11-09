namespace AbrirArchivo2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Todos los archivos";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                lblArchivo.Text=ofd.FileName;
            }
            ofd.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}