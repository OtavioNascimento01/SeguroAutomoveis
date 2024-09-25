namespace SeguroAutomóveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float valorTotal = 0;
            float valorSeguro = 0;

            if (rbCivic.Checked)
                valorTotal += 150000;
            if (rb320i.Checked)
                valorTotal += 200000;
            if (rbA250.Checked)
                valorTotal += 210000;
            if (rbGolf.Checked)
                valorTotal += 190000;
            if (rbCorolla.Checked)
                valorTotal += 300000;

            //cálculo para o valor do seguro

            int anoSelecionado = int.Parse(txtAno.Text);

            if (anoSelecionado > 2014)
            {
                float percentual = 10 - (2024 - anoSelecionado);

                valorSeguro = valorTotal * (percentual / 100);
            } else
            {
                valorSeguro = 0;
            }


            //cálculo para desconto no seguro

            if (rbRua.Checked)
                valorSeguro += valorSeguro * 0.1f;
            if (rbEstacionamento.Checked)
                valorSeguro -= valorSeguro * 0.06f;
            if (rbGaragem.Checked)
                valorSeguro -= valorSeguro * 0.15f;

            if(rbFaixa1.Checked)
                valorSeguro += valorSeguro * 0.08f;
            if (rbFaixa3.Checked)
                valorSeguro -= valorSeguro * 0.11f;
            if (rbFaixa4.Checked)
                valorSeguro -= valorSeguro * 0.02f;

            if (cbAlarme.Checked)
                valorSeguro = valorSeguro - 150;
            if (cbTrava.Checked)
                valorSeguro = valorSeguro - 230;
            if (cbAntiFurto.Checked)
                valorSeguro += valorSeguro - 285;

            txtSeguro.Text = valorSeguro.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

            float soma = valorSeguro + valorTotal;
            txtTotal.Text = soma.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
