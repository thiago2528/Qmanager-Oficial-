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
    public partial class Registro_Arbitro : Form
    {
        public Registro_Arbitro()
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

        private void Registro_Arbitro_Load(object sender, EventArgs e) { }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una foto
            if (string.IsNullOrEmpty(PicFoto.ImageLocation))
            {
                MessageBox.Show("Por favor, selecciona una foto de perfil antes de guardar.");
                return; // Sale del método sin continuar el guardado
            }

            // Crear un objeto CEArbitro con los datos del formulario
            CEArbitro arbitro = new CEArbitro
            {
                Cedula = TxtCedula.Texts,
                Nombre = TxtNombre.Texts,
                Apellido = TxtApellido.Texts,
                Foto = PicFoto.ImageLocation,
                Password = TxtCedula.Texts,
            };

            // Verificar si la cédula ya existe
            if (Arbitro.ExisteCedula(arbitro.Cedula))
            {
                // Si existe, proceder a modificar
                int result = Arbitro.ModificarArbitro(arbitro);
                MessageBox.Show(result > 0 ? "Árbitro modificado exitosamente." : "Error al modificar el árbitro.");
            }
            else
            {
                // Si no existe, proceder a agregar
                int result = Arbitro.AgregarArbitro(arbitro);
                MessageBox.Show(result > 0 ? "Datos guardados exitosamente." : "Error al guardar los datos.");
            }

            RefreshPantalla();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se ha hecho clic en la columna de Foto
            if (e.ColumnIndex == dataGridView1.Columns["Foto"].Index && e.RowIndex >= 0)
            {
                string fotoUrl = dataGridView1.Rows[e.RowIndex].Cells["Foto"].Value.ToString();

                // Mostrar la imagen en un PictureBox
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
            dataGridView1.AutoGenerateColumns = false; // No generar columnas automáticamente
            dataGridView1.Columns.Clear(); // Limpiar columnas anteriores

            // Definir columnas
            dataGridView1.Columns.Add("Cedula", "Cédula");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");

            // Columna de Foto como Link
            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn
            {
                HeaderText = "Foto",
                Name = "Foto",
                DataPropertyName = "Foto"
            };
            dataGridView1.Columns.Add(linkColumn);


            List<CEArbitro> arbitros = Arbitro.PresentarRegistro();
            foreach (CEArbitro arbitro in arbitros)
            {
                dataGridView1.Rows.Add(arbitro.Cedula, arbitro.Nombre, arbitro.Apellido, arbitro.Foto);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay filas seleccionadas
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Crear una lista para almacenar las cédulas a eliminar
                List<string> cedulasAEliminar = new List<string>();

                // Recorrer las filas seleccionadas y agregar las cédulas a la lista
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string cedula = row.Cells["Cedula"].Value.ToString();
                    cedulasAEliminar.Add(cedula);
                }

                // Borrar los árbitros seleccionados
                foreach (string cedula in cedulasAEliminar)
                {
                    int resultado = Arbitro.EliminarArbitro(cedula);
                    if (resultado > 0)
                    {
                        MessageBox.Show($"El árbitro con cédula {cedula} ha sido eliminado.");
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar el árbitro con cédula {cedula}.");
                    }
                }

                // Refresca la pantalla para mostrar los cambios
                RefreshPantalla();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos un árbitro para eliminar.");
            }
        }


        private void label3_Click(object sender, EventArgs e) { }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string cedulaBusqueda = TxtCedulaBusqueda.Texts; // Obtén el texto ingresado en el campo de búsqueda

            if (!string.IsNullOrEmpty(cedulaBusqueda))
            {
                // Llama al método para buscar coincidencias parciales
                List<CEArbitro> arbitros = Arbitro.BuscarArbitrosPorCedulaParcial(cedulaBusqueda);

                if (arbitros.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (var arbitro in arbitros)
                    {
                        dataGridView1.Rows.Add(arbitro.Cedula, arbitro.Nombre, arbitro.Apellido, arbitro.Foto);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron árbitros con los datos ingresados.");
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
