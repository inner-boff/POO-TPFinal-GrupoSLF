namespace POO20Junio2022
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var validadorLogin = new ValidadorDeUsuarioYPassword();

            if (validadorLogin.Validador(textBox1.Text, textBox2.Text) == true)
            {
                MessageBox.Show("Login válido");
                var app = new menu();
                this.Hide(); // lo oculta pero sigue activo
                app.Show();
            }
            else
            {
                MessageBox.Show("usuario / contraseña incorrectos");
                textBox1.Clear();
                textBox2.Clear();   
                textBox1.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}