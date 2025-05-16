namespace LabTab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtSomar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1TabSomar.Text);
            double num2 = Convert.ToDouble(txtNum2TabSomar.Text);
            double resultado = num1 + num2;
            txtResultadoSomar.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1SubTab2.Text);
            double num2 = Convert.ToDouble(txtNum2SubTab2.Text);
            double resultado = num1 - num2;
            txtResultadoSubtracao.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1MultTab3.Text);
            double num2 = Convert.ToDouble(txtNum2MultTab3.Text);
            double resultado = num1 - num2;
            txtResultadoMultiplicacao.Text = resultado.ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1DivTab4.Text);
            double num2 = Convert.ToDouble(txtNum2DivTab4.Text);
            double resultado = num1 - num2;
            txtResultadoDivisao.Text = resultado.ToString();

        }
    }
}
