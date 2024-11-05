
namespace Qmanager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Cedula = new CustomControls.RJControls.RJTextBox();
            this.Password = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ojos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ojos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cedula
            // 
            this.Cedula.BackColor = System.Drawing.SystemColors.Window;
            this.Cedula.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Cedula.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Cedula.BorderRadius = 10;
            this.Cedula.BorderSize = 2;
            this.Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cedula.Location = new System.Drawing.Point(169, 174);
            this.Cedula.Margin = new System.Windows.Forms.Padding(4);
            this.Cedula.Multiline = false;
            this.Cedula.Name = "Cedula";
            this.Cedula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Cedula.PasswordChar = false;
            this.Cedula.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.Cedula.PlaceholderText = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(250, 39);
            this.Cedula.TabIndex = 3;
            this.Cedula.Texts = "";
            this.Cedula.UnderlinedStyle = false;
            this.Cedula._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Window;
            this.Password.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Password.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Password.BorderRadius = 10;
            this.Password.BorderSize = 2;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.Location = new System.Drawing.Point(169, 226);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Password.PasswordChar = true;
            this.Password.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.Password.PlaceholderText = "Contraseña";
            this.Password.Size = new System.Drawing.Size(250, 39);
            this.Password.TabIndex = 4;
            this.Password.Texts = "";
            this.Password.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cedula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(216, 278);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.Text = "Aceptar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(235, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 2;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(216, 127);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(100, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBox1.Size = new System.Drawing.Size(150, 30);
            this.rjComboBox1.TabIndex = 10;
            this.rjComboBox1.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo de Usuario";
            // 
            // ojos
            // 
            this.ojos.Image = global::Qmanager.Properties.Resources.Cerrado;
            this.ojos.Location = new System.Drawing.Point(440, 233);
            this.ojos.Name = "ojos";
            this.ojos.Size = new System.Drawing.Size(35, 30);
            this.ojos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ojos.TabIndex = 12;
            this.ojos.TabStop = false;
            this.ojos.Click += new System.EventHandler(this.ojos_Click);
            // 
            // Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.ojos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rjComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Cedula);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ojos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJTextBox Cedula;
        private CustomControls.RJControls.RJTextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ojos;
    }
}