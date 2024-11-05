
namespace Qmanager
{
    partial class Pantalla_Administrador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Administrador));
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.Registros = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.rjDropdownMenu1 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.registroAtletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroArbitroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox2 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.rjDropdownMenu1.SuspendLayout();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rjButton2
            // 
            this.rjButton2.AutoSize = true;
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(11, 225);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 6;
            this.rjButton2.Text = "Evento";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // Registros
            // 
            this.Registros.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Registros.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Registros.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Registros.BorderRadius = 10;
            this.Registros.BorderSize = 0;
            this.Registros.FlatAppearance.BorderSize = 0;
            this.Registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registros.ForeColor = System.Drawing.Color.White;
            this.Registros.Location = new System.Drawing.Point(11, 113);
            this.Registros.Name = "Registros";
            this.Registros.Size = new System.Drawing.Size(150, 40);
            this.Registros.TabIndex = 7;
            this.Registros.Text = "Registros";
            this.Registros.TextColor = System.Drawing.Color.White;
            this.Registros.UseVisualStyleBackColor = false;
            this.Registros.Click += new System.EventHandler(this.Registros_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(12, 169);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 5;
            this.rjButton1.Text = "Historial";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.Registros);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.rjButton4);
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 783);
            this.panel1.TabIndex = 10;
            // 
            // rjButton4
            // 
            this.rjButton4.AutoSize = true;
            this.rjButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 10;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(11, 280);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(150, 40);
            this.rjButton4.TabIndex = 4;
            this.rjButton4.Text = "Carnet";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.Blue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(17, 609);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            this.rjCircularPictureBox1.Click += new System.EventHandler(this.rjCircularPictureBox1_Click);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroAtletaToolStripMenuItem,
            this.registroArbitroToolStripMenuItem,
            this.registroProfesorToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(176, 70);
            // 
            // registroAtletaToolStripMenuItem
            // 
            this.registroAtletaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroAtletaToolStripMenuItem.Name = "registroAtletaToolStripMenuItem";
            this.registroAtletaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registroAtletaToolStripMenuItem.Text = "Registro Atleta";
            this.registroAtletaToolStripMenuItem.Click += new System.EventHandler(this.registroAtletaToolStripMenuItem_Click);
            // 
            // registroArbitroToolStripMenuItem
            // 
            this.registroArbitroToolStripMenuItem.Name = "registroArbitroToolStripMenuItem";
            this.registroArbitroToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registroArbitroToolStripMenuItem.Text = "Registro Arbitro";
            this.registroArbitroToolStripMenuItem.Click += new System.EventHandler(this.registroArbitroToolStripMenuItem_Click);
            // 
            // registroProfesorToolStripMenuItem
            // 
            this.registroProfesorToolStripMenuItem.Name = "registroProfesorToolStripMenuItem";
            this.registroProfesorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registroProfesorToolStripMenuItem.Text = "Registro Profesor";
            this.registroProfesorToolStripMenuItem.Click += new System.EventHandler(this.registroProfesorToolStripMenuItem_Click);
            // 
            // PanelForm
            // 
            this.PanelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelForm.AutoSize = true;
            this.PanelForm.BackColor = System.Drawing.Color.Transparent;
            this.PanelForm.BackgroundImage = global::Qmanager.Properties.Resources.Inicio;
            this.PanelForm.Controls.Add(this.rjCircularPictureBox2);
            this.PanelForm.Location = new System.Drawing.Point(180, -1);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(842, 783);
            this.PanelForm.TabIndex = 11;
            // 
            // rjCircularPictureBox2
            // 
            this.rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox2.BorderColor2 = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox2.BorderSize = 3;
            this.rjCircularPictureBox2.GradientAngle = 50F;
            this.rjCircularPictureBox2.Image = global::Qmanager.Properties.Resources.LOGO_cuk;
            this.rjCircularPictureBox2.Location = new System.Drawing.Point(258, 202);
            this.rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            this.rjCircularPictureBox2.Size = new System.Drawing.Size(320, 320);
            this.rjCircularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox2.TabIndex = 0;
            this.rjCircularPictureBox2.TabStop = false;
            // 
            // Pantalla_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 781);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_Administrador";
            this.Text = "Pantalla_Administrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton Registros;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel PanelForm;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox2;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem registroAtletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroArbitroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProfesorToolStripMenuItem;
    }
}