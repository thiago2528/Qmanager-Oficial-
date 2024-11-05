
using System;

namespace Qmanager
{
    partial class Evento
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
            this.txtCantidadParticipantes = new System.Windows.Forms.TextBox();
            this.txtNombresParticipantes = new System.Windows.Forms.TextBox();
            this.btnGenerarFixture = new System.Windows.Forms.Button();
            this.panelFixture = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtCantidadParticipantes
            // 
            this.txtCantidadParticipantes.ForeColor = System.Drawing.Color.Gray;
            this.txtCantidadParticipantes.Location = new System.Drawing.Point(20, 20);
            this.txtCantidadParticipantes.Name = "txtCantidadParticipantes";
            this.txtCantidadParticipantes.Size = new System.Drawing.Size(200, 20);
            this.txtCantidadParticipantes.TabIndex = 0;
            this.txtCantidadParticipantes.Text = "Cantidad de participantes";
            // 
            // txtNombresParticipantes
            // 
            this.txtNombresParticipantes.ForeColor = System.Drawing.Color.Gray;
            this.txtNombresParticipantes.Location = new System.Drawing.Point(20, 60);
            this.txtNombresParticipantes.Multiline = true;
            this.txtNombresParticipantes.Name = "txtNombresParticipantes";
            this.txtNombresParticipantes.Size = new System.Drawing.Size(200, 100);
            this.txtNombresParticipantes.TabIndex = 1;
            this.txtNombresParticipantes.Text = "Nombres de los participantes ";
            // 
            // btnGenerarFixture
            // 
            this.btnGenerarFixture.Location = new System.Drawing.Point(20, 180);
            this.btnGenerarFixture.Name = "btnGenerarFixture";
            this.btnGenerarFixture.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarFixture.TabIndex = 2;
            this.btnGenerarFixture.Text = "Generar Fixture";
            this.btnGenerarFixture.UseVisualStyleBackColor = true;
            // 
            // panelFixture
            // 
            this.panelFixture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFixture.Location = new System.Drawing.Point(250, 20);
            this.panelFixture.Name = "panelFixture";
            this.panelFixture.Size = new System.Drawing.Size(800, 600);
            this.panelFixture.TabIndex = 3;
            // 
            // Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 625);
            this.Controls.Add(this.panelFixture);
            this.Controls.Add(this.btnGenerarFixture);
            this.Controls.Add(this.txtNombresParticipantes);
            this.Controls.Add(this.txtCantidadParticipantes);
            this.Name = "Evento";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.Evento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        


        #endregion

        private System.Windows.Forms.TextBox txtCantidadParticipantes;
        private System.Windows.Forms.TextBox txtNombresParticipantes;
        private System.Windows.Forms.Button btnGenerarFixture;
        private System.Windows.Forms.Panel panelFixture;
    }
}