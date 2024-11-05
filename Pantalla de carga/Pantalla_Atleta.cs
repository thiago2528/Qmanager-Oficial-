using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Qmanager
{
    public partial class Pantalla_Atleta : Form
    {

        private ContextMenuStrip menuDesplegable;

        public Pantalla_Atleta()
        {
            InitializeComponent();

            menuDesplegable = new ContextMenuStrip();
            menuDesplegable.Items.Add("Cerrar Sesión");
            menuDesplegable.Items.Add("Configuración");
            menuDesplegable.Items.Add("Mi Perfil");


            menuDesplegable.ItemClicked += MenuDesplegable_ItemClicked;
        }

        private void Pantalla_Atleta_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Evento());
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
          
            var boton = sender as Control;
            int x = boton.Left;
            int y = boton.Top - menuDesplegable.Height; 

       
            menuDesplegable.Show(this, new Point(x, y));
        }

   
        private void MenuDesplegable_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Text)
            {
                case "Cerrar Sesión":
         
                    
                    MessageBox.Show("Cerrando sesión...");
                    Login inicio = new Login();
                    this.Hide();
                    inicio.Show();

                    this.Close(); 

                    break;

                case "Configuración":
                 
                    AbrirFormularioEnPanel(new Registro_Atleta());
                    break;

                case "Mi Perfil":

                    MessageBox.Show("Entraste a tu perfil");
                    break;
            }
        }
        private void AbrirFormularioEnPanel(Form formPrincipal)
        {
            if (PanelForm.Controls.Count > 0)
                PanelForm.Controls.RemoveAt(0); 

            formPrincipal.TopLevel = false; 
            formPrincipal.FormBorderStyle = FormBorderStyle.None; 
            formPrincipal.Dock = DockStyle.Fill; 
            PanelForm.Controls.Add(formPrincipal); 
            PanelForm.Tag = formPrincipal; 
            formPrincipal.Show(); 

        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
