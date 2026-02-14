namespace FormTXT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNombre = new Label();
            lbApellidos = new Label();
            Telefono = new Label();
            lbEstatura = new Label();
            lbEdad = new Label();
            Genero = new GroupBox();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            btnGuardar = new Button();
            Limpiar = new Button();
            tbNombre = new TextBox();
            tbApellidos = new TextBox();
            tbTelefono = new TextBox();
            tbEstatura = new TextBox();
            tbEdad = new TextBox();
            Genero.SuspendLayout();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(50, 53);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(93, 25);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre/s";
            // 
            // lbApellidos
            // 
            lbApellidos.AutoSize = true;
            lbApellidos.Location = new Point(50, 101);
            lbApellidos.Name = "lbApellidos";
            lbApellidos.Size = new Size(93, 25);
            lbApellidos.TabIndex = 0;
            lbApellidos.Text = "Apellido/s";
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Location = new Point(50, 155);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(79, 25);
            Telefono.TabIndex = 0;
            Telefono.Text = "Telefono";
            // 
            // lbEstatura
            // 
            lbEstatura.AutoSize = true;
            lbEstatura.Location = new Point(50, 212);
            lbEstatura.Name = "lbEstatura";
            lbEstatura.Size = new Size(75, 25);
            lbEstatura.TabIndex = 0;
            lbEstatura.Text = "Estatura";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(50, 261);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(52, 25);
            lbEdad.TabIndex = 0;
            lbEdad.Text = "Edad";
            // 
            // Genero
            // 
            Genero.Controls.Add(rbMasculino);
            Genero.Controls.Add(rbFemenino);
            Genero.Location = new Point(24, 327);
            Genero.Name = "Genero";
            Genero.Size = new Size(437, 94);
            Genero.TabIndex = 1;
            Genero.TabStop = false;
            Genero.Text = "bgGenero";
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(260, 44);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(117, 29);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(38, 44);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(115, 29);
            rbFemenino.TabIndex = 0;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(65, 478);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(284, 478);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(112, 34);
            Limpiar.TabIndex = 2;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(260, 57);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(150, 31);
            tbNombre.TabIndex = 3;
            // 
            // tbApellidos
            // 
            tbApellidos.Location = new Point(260, 101);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(150, 31);
            tbApellidos.TabIndex = 3;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(260, 155);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(150, 31);
            tbTelefono.TabIndex = 3;
            // 
            // tbEstatura
            // 
            tbEstatura.Location = new Point(260, 209);
            tbEstatura.Name = "tbEstatura";
            tbEstatura.Size = new Size(150, 31);
            tbEstatura.TabIndex = 3;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(260, 258);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(150, 31);
            tbEdad.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 550);
            Controls.Add(tbEdad);
            Controls.Add(tbEstatura);
            Controls.Add(tbTelefono);
            Controls.Add(tbApellidos);
            Controls.Add(tbNombre);
            Controls.Add(Limpiar);
            Controls.Add(btnGuardar);
            Controls.Add(Genero);
            Controls.Add(lbEdad);
            Controls.Add(lbEstatura);
            Controls.Add(Telefono);
            Controls.Add(lbApellidos);
            Controls.Add(lbNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Genero.ResumeLayout(false);
            Genero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private Label lbApellidos;
        private Label Telefono;
        private Label lbEstatura;
        private Label lbEdad;
        private GroupBox Genero;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        private Button btnGuardar;
        private Button Limpiar;
        private TextBox tbNombre;
        private TextBox tbApellidos;
        private TextBox tbTelefono;
        private TextBox tbEstatura;
        private TextBox tbEdad;
    }
}
