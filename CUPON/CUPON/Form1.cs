namespace CUPON
{
    public partial class Form1 : Form
    {
        private CUPONS cuponcito;
        public Form1()
        {
            cuponcito = new CUPONS();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TXTMONTO.Text = "$" + cuponcito.MONTO;
            this.TXTCUPON.Text = cuponcito.CUPON;
            TXTPAGO.Text = "$" + cuponcito.MONTO;
            TXTDESC.Text = cuponcito.CALCULAR_DESCUENTO().ToString();
            TXTTAL.Text = cuponcito.TOTAL.ToString();
        }

        private void BTNCOMPRA_Click(object sender, EventArgs e)
        {
            if (TXTCUPON.Text == "MX15")
            {
                try
                {
                    //ASIGNA EL MONTO DESDE LA CAJA DE TEXTO
                    cuponcito.MONTO = float.Parse(TXTMONTO.Text.Replace("$", ""));
                    cuponcito.CUPON = TXTCUPON.Text;

                    cuponcito.Calcular_TOTAL();

                    //MUESTRA LOS RESULTADOS
                    TXTPAGO.Text = "$" + cuponcito.MONTO.ToString("0.00");
                    TXTDESC.Text = "$" + cuponcito.CALCULAR_DESCUENTO().ToString("0.00");
                    TXTTAL.Text ="$" + cuponcito.Calcular_TOTAL().ToString("0.00");
                }
                catch
                {
                    MessageBox.Show("Los datos capturados no son validos");
                    TXTTAL.Text = "";
                }
            }
        }
    }
}
