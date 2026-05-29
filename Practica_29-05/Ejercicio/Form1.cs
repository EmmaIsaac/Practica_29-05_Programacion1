using Ejercicio.Services;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ExpedienteService expedienteService = new ExpedienteService();
        Form2 formulario2 = new Form2();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string dni = tbDNI.Text;
            double monto = Convert.ToDouble(tbMonto.Text);

            expedienteService.RegistrarExpediente(nombre, dni, monto);

            tbNombre.Text = "";
            tbDNI.Text = "";
            tbMonto.Text = "";


        }

        private void btnVerExpedientes_Click(object sender, EventArgs e)
        {
            formulario2.ShowDialog();
        }
    }
}
