namespace Prova2Bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_vlrVenda.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tx_valor.Text);
            int pis = Convert.ToInt32(tx_pis.Text);
            int icms = Convert.ToInt32(tx_icms.Text);
            int confins = Convert.ToInt32(tx_confins.Text);
            int lucro = Convert.ToInt32(tx_lucro.Text);
            string unidade = cb_unidade.Text;

            Produto produto = new Produto(valor, pis, icms, confins, lucro);
            double resultado = produto.Calculo(unidade);
            lb_vlrVenda.Text = Convert.ToString(resultado);
        }
    }
}