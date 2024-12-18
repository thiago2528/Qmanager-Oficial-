﻿using System;
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
    public partial class Pantalla_Administrador : Form
    {
        private ContextMenuStrip menuDesplegable;
        public Pantalla_Administrador()
        {
            InitializeComponent();
            menuDesplegable = new ContextMenuStrip();
            menuDesplegable.Items.Add("Cerrar Sesión");
            menuDesplegable.Items.Add("Configuración");
            menuDesplegable.Items.Add("Mi Perfil");


            menuDesplegable.ItemClicked += MenuDesplegable_ItemClicked;
        }

        private void Pantalla_Administrador_Load(object sender, EventArgs e)
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

        private void Registros_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(Registros, Registros.Width, 0);
        }

        private void registroAtletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Registro_Atleta());
        }

        private void registroArbitroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Registro_Arbitro());
        }

        private void registroProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Registro_Profesor());
        }

        private void Evento_Click(object sender, EventArgs e)
        {
            rjDropdownMenu2.Show(Evento, Evento.Width, 0);
        }
    }
}
