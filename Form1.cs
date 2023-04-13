namespace Calculadora
{
    public partial class Form1 : Form
    {

        double calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;  

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtOperacao.Text += "1";


        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtOperacao.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtOperacao.Text += "3";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtOperacao.Text += "4";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtOperacao.Text += "5";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtOperacao.Text += "6";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtOperacao.Text += "7";


        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtOperacao.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtOperacao.Text += "9";


        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtOperacao.Text += "0";


        }


        private void buttonequal_Click(object sender, EventArgs e)
        {
           
            txtOperacao.Text += "=";

           resultado = true;

            if(adicao == true)
            {
                txtResultado.Text = Convert.ToString(double.Parse(txtResultado.Text) + calculo);

                txtOperacao.Text += txtResultado.Text;
            }

            else if  (subtracao == true)
            {
                txtResultado.Text = Convert.ToString(calculo- double.Parse(txtResultado.Text));

                txtOperacao.Text += txtResultado.Text;
            }

            else if (multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(double.Parse(txtResultado.Text) * calculo);
                txtOperacao.Text += "*" + txtResultado.Text;
            }
            else if (divisao == true)
            {
                txtResultado.Text = Convert.ToString(calculo /double.Parse(txtResultado.Text));
                txtOperacao.Text += txtResultado.Text;
            }
        }

        private void buttonmult_Click(object sender, EventArgs e)
        {

            txtOperacao.Text += "*";
            calculo = Double.Parse(txtResultado.Text);
            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;

        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            
            txtOperacao.Text += "/";
            calculo = Double.Parse(txtResultado.Text);
             txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void buttonless_Click(object sender, EventArgs e)
        {
            
           calculo = Double.Parse(txtResultado.Text);

            txtOperacao.Text += "-";

            txtResultado.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtOperacao.Text = "";
        }

        private void buttoncomma_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
            txtOperacao.Text += ",";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            calculo = Double.Parse (txtResultado.Text);

            txtOperacao.Text += "+";

            txtResultado.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;

        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}