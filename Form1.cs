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
            double pis = Convert.ToDouble(tx_pis.Text);
            double icms = Convert.ToDouble(tx_icms.Text);
            double confins = Convert.ToDouble(tx_confins.Text);
            double lucro = Convert.ToDouble(tx_lucro.Text);
            string unidade = cb_unidade.Text;

            Produto produto = new Produto(valor, pis, icms, confins, lucro);
            double resultado = produto.Calculo(unidade);
            MessageBox.Show(resultado.ToString("c2"));
            lb_vlrVenda.Text = resultado.ToString("c2");
        }
    }
}