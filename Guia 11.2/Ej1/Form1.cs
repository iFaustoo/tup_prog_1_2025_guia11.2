namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Servicio servicio = new Servicio();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbNumero.Text);
            servicio.RegistrarValor(valor);
            tbNumero.Clear();
        }

        private void btnActualizarMyM_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbMaximo.Text = $"{servicio.CalcularMaximo()}";
                lbMinimo.Text = $"{servicio.CalcularMinimo()}";
            }
            else
            {
                lbMaximo.Text = "-";
                lbMinimo.Text = "-";
            }
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbPromedio.Text = $"{servicio.CalcularPromedio():f2}";
            }
            else
            {
                lbPromedio.Text = "-";
            }
        }

        private void btnActualizarC_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbCantidad.Text = $"{servicio.Contador}";
            }
            else
            {
                lbCantidad.Text = "-";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbValorABuscar.Text);
            int idx = servicio.BuscarValor(valor);

            if (idx > -1)
            {
                lbValorABuscar.Text = $"Ingresado en la posición: {idx}";
            }
            else
            {
                lbValorABuscar.Text = "No existe";
            }
        }

        private void btnListaOrdenada_Click(object sender, EventArgs e)
        {
            servicio.OrdenarLista();
            tbCantidadIngresados.Clear();

            for (int i = 0; i < servicio.Contador; i++)
            {
                tbCantidadIngresados.Text += $"{servicio.Lista[i]}\n";
            }
        }

        private void btnSuperior_Click(object sender, EventArgs e)
        {
            tbCantidadIngresados.Clear();
            int cantidad;
            int[] lista = servicio.ListaSuperioresAlPromedio(out cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                tbCantidadIngresados.Text += $"{lista[i]}";
            }
        }
    }
}
