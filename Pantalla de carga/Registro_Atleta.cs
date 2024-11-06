using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Qmanager
{
    public partial class Registro_Atleta : Form
    {
        public Registro_Atleta()
        {
            InitializeComponent();
            TxtCedula.KeyPress += TxtCedula_KeyPress;
            TxtNombre.KeyPress += TxtNombre_KeyPress;
            TxtApellido.KeyPress += TxtApellido_KeyPress;
            TxtCedulaBusqueda.KeyPress += TxtCedulaBusqueda_KeyPress;
            RefreshPantalla();
        }

        private void TxtCedulaBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el `Enter` agregue una nueva línea
                BtnBuscar.PerformClick(); // Ejecuta el clic del botón BtnBuscar
            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el `Enter` agregue una nueva línea
                TxtNombre.Focus();
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                TxtApellido.Focus();
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                // Aquí puedes enfocar otro control, o guardar datos, etc.
                BtnGuardar.Focus(); // Ejemplo: Enfocar el botón de guardar
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtCedula.Texts = null;
            TxtNombre.Texts = null;
            TxtApellido.Texts = null;
            PicFoto.Image = null;
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e) { }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e) { LnkLabel_LinkClicked(this, null); }

        private void LnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OpnDialog.ShowDialog() == DialogResult.OK)
            {
                PicFoto.Load(OpnDialog.FileName);
            }
            OpnDialog.FileName = string.Empty;
        }

        private void Registro_Atleta_Load(object sender, EventArgs e) { }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrEmpty(PicFoto.ImageLocation))
            {
                MessageBox.Show("Por favor, selecciona una foto de perfil antes de guardar.");
                return; // Sale del método sin continuar el guardado
            }


            CEAtleta atleta = new CEAtleta
            {
                Cedula = TxtCedula.Texts,
                Nombre = TxtNombre.Texts,
                Apellido = TxtApellido.Texts,
                Foto = PicFoto.ImageLocation,
                Password = TxtCedula.Texts,
            };


            if (Atleta.ExisteCedula(atleta.Cedula))
            {

                int result = Atleta.ModificarAtleta(atleta);
                MessageBox.Show(result > 0 ? "Atleta modificado exitosamente." : "Error al modificar el atleta.");
            }
            else
            {
          
                int result = Atleta.AgregarAtleta(atleta);
                MessageBox.Show(result > 0 ? "Datos guardados exitosamente." : "Error al guardar los datos.");
            }

            RefreshPantalla();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
            if (e.ColumnIndex == dataGridView1.Columns["Foto"].Index && e.RowIndex >= 0)
            {
                string fotoUrl = dataGridView1.Rows[e.RowIndex].Cells["Foto"].Value.ToString();


                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(fotoUrl),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill
                };

                Form previewForm = new Form
                {
                    Size = new Size(300, 300),
                    Text = "Foto de Perfil"
                };
                previewForm.Controls.Add(pictureBox);
                previewForm.ShowDialog();
            }
          
        }

        public void RefreshPantalla()
        {
            dataGridView1.AutoGenerateColumns = false; 
            dataGridView1.Columns.Clear(); 

            // Definir columnas
            dataGridView1.Columns.Add("Cedula", "Cédula");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");

            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn
            {
                HeaderText = "Foto",
                Name = "Foto",
                DataPropertyName = "Foto"
            };
            dataGridView1.Columns.Add(linkColumn);


            List<CEAtleta> atletas = Atleta.PresentarRegistro();
            foreach (CEAtleta atleta in atletas)
            {
                dataGridView1.Rows.Add(atleta.Cedula, atleta.Nombre, atleta.Apellido, atleta.Foto);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                List<string> cedulasAEliminar = new List<string>();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string cedula = row.Cells["Cedula"].Value.ToString();
                    cedulasAEliminar.Add(cedula);
                }

                foreach (string cedula in cedulasAEliminar)
                {
                    int resultado = Atleta.EliminarAtleta(cedula);
                    if (resultado > 0)
                    {
                        MessageBox.Show($"El atleta con cédula {cedula} ha sido eliminado.");
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar el atleta con cédula {cedula}.");
                    }
                }

           
                RefreshPantalla();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos un atleta para eliminar.");
            }
        }
        

        private void label3_Click(object sender, EventArgs e) { }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string cedulaBusqueda = TxtCedulaBusqueda.Texts; 

            if (!string.IsNullOrEmpty(cedulaBusqueda))
            {
                List<CEAtleta> atletas = Atleta.BuscarAtletasPorCedulaParcial(cedulaBusqueda);

                if (atletas.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (var atleta in atletas)
                    {
                        dataGridView1.Rows.Add(atleta.Cedula, atleta.Nombre, atleta.Apellido, atleta.Foto);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron atletas con los datos ingresados.");
                }
            }
            else
            {
                RefreshPantalla();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
