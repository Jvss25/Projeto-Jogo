namespace projetoJogo_devsKnights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            Game joguinho = new Game();
            joguinho.Show();
            Hide();
        }
    }
}
