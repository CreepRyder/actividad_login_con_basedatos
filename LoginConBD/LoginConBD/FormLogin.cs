namespace LoginConDB
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            //Validamos que se haya ingresado un usuario
            if(txtUsuario.Text == "")
            {

                MessageBox.Show("Se debe ingresar un usuario.");
                return;

            }

            //Validamos que haya ingresado Password

            if(txtPassword.Text == "")
            {

                MessageBox.Show("Se debe ingresar una contraseña.");
                return;

            }

            MessageBox.Show("Usted a ingresado correctamente al sistema.");
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}