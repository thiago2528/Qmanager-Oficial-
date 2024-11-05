
namespace Qmanager
{
    partial class Registro_Profesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpnDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnEliminar = new CustomControls.RJControls.RJButton();
            this.BtnGuardar = new CustomControls.RJControls.RJButton();
            this.PicFoto = new CustomControls.RJControls.RJCircularPictureBox();
            this.BtnBorrar = new CustomControls.RJControls.RJButton();
            this.link = new System.Windows.Forms.LinkLabel();
            this.LblFoto = new System.Windows.Forms.Label();
            this.BtnBuscar = new CustomControls.RJControls.RJButton();
            this.TxtCedulaBusqueda = new CustomControls.RJControls.RJTextBox();
            this.TxtCedula = new CustomControls.RJControls.RJTextBox();
            this.TxtNombre = new CustomControls.RJControls.RJTextBox();
            this.TxtApellido = new CustomControls.RJControls.RJTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpnDialog
            // 
            this.OpnDialog.FileName = "openFileDialog1";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnEliminar.BorderRadius = 19;
            this.BtnEliminar.BorderSize = 1;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(146, 467);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 40);
            this.BtnEliminar.TabIndex = 19;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextColor = System.Drawing.Color.White;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnGuardar.BorderRadius = 19;
            this.BtnGuardar.BorderSize = 1;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(244, 467);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 40);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PicFoto
            // 
            this.PicFoto.BackColor = System.Drawing.Color.Transparent;
            this.PicFoto.BackgroundImage = global::Qmanager.Properties.Resources.usuario;
            this.PicFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicFoto.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PicFoto.BorderColor = System.Drawing.Color.Black;
            this.PicFoto.BorderColor2 = System.Drawing.Color.Black;
            this.PicFoto.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PicFoto.BorderSize = 0;
            this.PicFoto.GradientAngle = 50F;
            this.PicFoto.Image = global::Qmanager.Properties.Resources.usuario;
            this.PicFoto.Location = new System.Drawing.Point(116, 288);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(161, 161);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto.TabIndex = 21;
            this.PicFoto.TabStop = false;
            this.PicFoto.Click += new System.EventHandler(this.rjCircularPictureBox1_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnBorrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnBorrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnBorrar.BorderRadius = 19;
            this.BtnBorrar.BorderSize = 1;
            this.BtnBorrar.FlatAppearance.BorderSize = 0;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.ForeColor = System.Drawing.Color.White;
            this.BtnBorrar.Location = new System.Drawing.Point(48, 467);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(92, 40);
            this.BtnBorrar.TabIndex = 18;
            this.BtnBorrar.Text = "Nuevo";
            this.BtnBorrar.TextColor = System.Drawing.Color.White;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.BackColor = System.Drawing.Color.Transparent;
            this.link.Location = new System.Drawing.Point(39, 321);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(63, 13);
            this.link.TabIndex = 28;
            this.link.TabStop = true;
            this.link.Text = "Seleccionar";
            this.link.Visible = false;
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLabel_LinkClicked);
            // 
            // LblFoto
            // 
            this.LblFoto.AutoSize = true;
            this.LblFoto.BackColor = System.Drawing.Color.Transparent;
            this.LblFoto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoto.ForeColor = System.Drawing.Color.White;
            this.LblFoto.Location = new System.Drawing.Point(66, 268);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(44, 18);
            this.LblFoto.TabIndex = 25;
            this.LblFoto.Text = "Foto";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.BackgroundColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.BackgroundImage = global::Qmanager.Properties.Resources.buscar;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBuscar.BorderRadius = 0;
            this.BtnBuscar.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(704, 65);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(40, 40);
            this.BtnBuscar.TabIndex = 32;
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCedulaBusqueda
            // 
            this.TxtCedulaBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCedulaBusqueda.AutoSize = true;
            this.TxtCedulaBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCedulaBusqueda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtCedulaBusqueda.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.TxtCedulaBusqueda.BorderRadius = 0;
            this.TxtCedulaBusqueda.BorderSize = 2;
            this.TxtCedulaBusqueda.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TxtCedulaBusqueda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedulaBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCedulaBusqueda.Location = new System.Drawing.Point(409, 78);
            this.TxtCedulaBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCedulaBusqueda.Multiline = true;
            this.TxtCedulaBusqueda.Name = "TxtCedulaBusqueda";
            this.TxtCedulaBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtCedulaBusqueda.PasswordChar = false;
            this.TxtCedulaBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtCedulaBusqueda.PlaceholderText = "";
            this.TxtCedulaBusqueda.Size = new System.Drawing.Size(279, 27);
            this.TxtCedulaBusqueda.TabIndex = 33;
            this.TxtCedulaBusqueda.Texts = "";
            this.TxtCedulaBusqueda.UnderlinedStyle = false;
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCedula.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtCedula.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtCedula.BorderRadius = 0;
            this.TxtCedula.BorderSize = 2;
            this.TxtCedula.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtCedula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCedula.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtCedula.Location = new System.Drawing.Point(143, 106);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCedula.Multiline = true;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtCedula.PasswordChar = false;
            this.TxtCedula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtCedula.PlaceholderText = "";
            this.TxtCedula.Size = new System.Drawing.Size(133, 27);
            this.TxtCedula.TabIndex = 22;
            this.TxtCedula.Texts = "";
            this.TxtCedula.UnderlinedStyle = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombre.BorderRadius = 0;
            this.TxtNombre.BorderSize = 2;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNombre.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtNombre.Location = new System.Drawing.Point(144, 154);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtNombre.PasswordChar = false;
            this.TxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.Size = new System.Drawing.Size(133, 27);
            this.TxtNombre.TabIndex = 26;
            this.TxtNombre.Texts = "";
            this.TxtNombre.UnderlinedStyle = false;
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.TxtApellido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtApellido.BorderRadius = 0;
            this.TxtApellido.BorderSize = 2;
            this.TxtApellido.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtApellido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtApellido.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtApellido.Location = new System.Drawing.Point(144, 205);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TxtApellido.Multiline = true;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtApellido.PasswordChar = false;
            this.TxtApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtApellido.PlaceholderText = "";
            this.TxtApellido.Size = new System.Drawing.Size(133, 27);
            this.TxtApellido.TabIndex = 27;
            this.TxtApellido.Texts = "";
            this.TxtApellido.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 315);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 23;
            // 
            // Registro_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Qmanager.Properties.Resources.Inicio;
            this.ClientSize = new System.Drawing.Size(793, 573);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.link);
            this.Controls.Add(this.LblFoto);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtCedulaBusqueda);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Profesor";
            this.Text = "Registro Profesor";
            this.Load += new System.EventHandler(this.Registro_Profesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpnDialog;
        private CustomControls.RJControls.RJButton BtnEliminar;
        private CustomControls.RJControls.RJButton BtnGuardar;
        private CustomControls.RJControls.RJCircularPictureBox PicFoto;
        private CustomControls.RJControls.RJButton BtnBorrar;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label LblFoto;
        private CustomControls.RJControls.RJButton BtnBuscar;
        private CustomControls.RJControls.RJTextBox TxtCedulaBusqueda;
        private CustomControls.RJControls.RJTextBox TxtCedula;
        private CustomControls.RJControls.RJTextBox TxtNombre;
        private CustomControls.RJControls.RJTextBox TxtApellido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}