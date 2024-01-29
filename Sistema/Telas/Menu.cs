

namespace Sistema.Telas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new PessoasForm();
            form.ShowDialog();
        }
    }
}