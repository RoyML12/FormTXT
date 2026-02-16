//V.001
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FormTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;
            string genero = "";
            if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            string datos = $"Nombres: {nombre}\r\n Apellidos: {apellidos}\r\n" + $" Edad: {edad}\r\n Estatura: {estatura}\r\n Telefono: {telefono}\r\n" + $"Genero: {genero}";
            MessageBox.Show("Datos guardados Correctamente: \r\n " + datos, "Informacion - Acividad 03", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string rutaArchivo = "C:\\Users\\roy70\\Desktop\\Programacion avanzada.txt";
            bool ArchivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
            {
                if (ArchivoExiste)
                {
                    escritor.WriteLine();
                }
                escritor.WriteLine(datos);
            }
            MessageBox.Show("Datos guardados Correctamente: \r\n " + datos, "Informacion - Acividad 03", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            tbApellidos.Clear();
            tbNombre.Clear();
            tbEdad.Clear();
            tbTelefono.Clear();
            tbEstatura.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
        }
    }
}