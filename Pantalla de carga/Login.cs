using MySql.Data.MySqlClient;
using Qmanager;
using System;
using System.Windows.Forms;

namespace Qmanager
{
    public partial class Login : Form
    {

  
        string conexion = "datasource=127.0.0.1;port=3306;database=db_qmanager;uid=root;pwd=;";
        private bool isPasswordVisible = false;
        public Login()
        {
            InitializeComponent();
            rjComboBox1.Items.Add(" ");
            rjComboBox1.Items.Add("Atleta");
            rjComboBox1.Items.Add("Profesor");
            rjComboBox1.Items.Add("Arbitro/Juez");
            Cedula.Controls[0].KeyDown += new KeyEventHandler(RjTextBox_KeyDown);
            Password.Controls[0].KeyDown += new KeyEventHandler(RjTextBox_KeyDown);
            try
            {
                using (MySqlConnection conectado = new MySqlConnection(conexion))
                {
                    conectado.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void RjTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == Cedula.Controls[0])
                {
                    Password.Focus(); // Mueve el foco al campo Password
                }
                else if (sender == Password.Controls[0])
                {
                    rjButton1.PerformClick(); // Activa el botón rjButton1
                }
                e.Handled = true;
                e.SuppressKeyPress = true; // Evita el sonido de "ding"
            }
        }

        public void rjButton1_Click(object sender, EventArgs e)
        {
            string cedula = Cedula.Texts;
            string password = Password.Texts;
            string role = rjComboBox1.SelectedItem?.ToString();
            


            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Por favor, completa todos los campos y selecciona un rol");
                return;
            } 
                    


            using (MySqlConnection conectado = new MySqlConnection(conexion))
            {
                try
                {
                    conectado.Open();

                    string query = "";
                    if (role == "Atleta")
                    {
                        query = "SELECT cedula, password FROM tb_atleta WHERE cedula = @cedula AND password = @password";
                    }
                    else if (role == "Profesor")
                    {
                        query = "SELECT cedula, password FROM tb_profesor WHERE cedula = @cedula AND password = @password";
                    }
                    else if (role == "Arbitro/Juez")
                    {
                        query = "SELECT cedula, password FROM tb_arbitro WHERE cedula = @cedula AND password = @password";
                    }
                    else if (role == " ")
                    {
                        query = "SELECT user, password FROM tb_administrador WHERE user = @user AND password = @password";
                    }
                 


                    if (!string.IsNullOrEmpty(query))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conectado))
                        {

                            cmd.Parameters.AddWithValue("@cedula", cedula);
                            cmd.Parameters.AddWithValue("@user", cedula);
                            cmd.Parameters.AddWithValue("@password", password);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Login exitoso");

                                    if (role == "Atleta")
                                    {
                                        Pantalla_Atleta AtletaForm = new Pantalla_Atleta();
                                        this.Hide();
                                        AtletaForm.Show();
                                    }
                                    else if (role == "Profesor")
                                    {
                                        Pantalla_Profesor profesorForm = new Pantalla_Profesor();
                                        this.Hide();
                                        profesorForm.Show();
                                    }
                                    else if (role == "Arbitro/Juez")
                                    {
                                        Pantalla_Arbitro arbitroForm = new Pantalla_Arbitro();
                                        this.Hide();
                                        arbitroForm.Show();
                                    }
                                    else if (role == " ")
                                    {
                                        Pantalla_Administrador AdministradorForm = new Pantalla_Administrador();
                                        this.Hide();
                                        AdministradorForm.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña incorrectos");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rol no válido seleccionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void rjButton2_Click(object sender, EventArgs e)
        {
            Registro_Atleta register = new Registro_Atleta();
            this.Hide();
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e) { }
        private void rjTextBox1__TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void ojos_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
             
                Password.PasswordChar = true;
                ojos.Image = Qmanager.Properties.Resources.Cerrado; 
                isPasswordVisible = false;
            }
            else
            {
                Password.PasswordChar = false;  
                ojos.Image = Qmanager.Properties.Resources.Abierto; 
                isPasswordVisible = true;
            }
        }
    }
}
