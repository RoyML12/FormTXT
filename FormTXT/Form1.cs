using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MySql.Data.MySqlClient;

namespace FormTXT
{
    public partial class Form1 : Form
    {
        string SQLConectkon = "Server=127.0.0.1; Port=3307; Database=programacionavanzada; Uid=root; Pwd=RoyML;";

        public Form1()
        {
            InitializeComponent();
            tbEdad.TextChanged += ValidarEdad;
            tbApellidos.TextChanged += ValidarApellidos;
            tbNombre.TextChanged += ValidarNombre;
            tbEstatura.TextChanged += ValidarEstatura;
            tbTelefono.Leave += ValidarTelefono;
        }

        private void insertarRegistros(string nombre, string apellidos, int edad, float estatura, string telefono, string genero)
        {
            using (MySqlConnection conectar = new MySqlConnection(SQLConectkon))
            {
                conectar.Open();
                string InsertQuery = "INSERT INTO registros (nombres, apellidos, telefono, estatura, edad, genero) VALUES (@nombres, @apellidos, @telefono, @estatura, @edad, @genero)";
                using (MySqlCommand comando = new MySqlCommand(InsertQuery, conectar))
                {
                    comando.Parameters.AddWithValue("@nombres", nombre);
                    comando.Parameters.AddWithValue("@apellidos", apellidos);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@estatura", estatura);
                    comando.Parameters.AddWithValue("@edad", edad);
                    comando.Parameters.AddWithValue("@genero", genero);
                    comando.ExecuteNonQuery();
                }
            }
        }

        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox cajaNombre = (TextBox)sender;
            if (!EsTextoValido(cajaNombre.Text))
            {
                MessageBox.Show("Ingrese valores correctos para el Nombre",
                "Error Nombre", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                cajaNombre.Clear();
            }
        }

        private void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox cajaApellidos = (TextBox)sender;
            if (!EsTextoValido(cajaApellidos.Text))
            {
                MessageBox.Show("Ingrese valores correctos para el apellido",
                "Error Apellido", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                cajaApellidos.Clear();
            }
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textboxEdad = (TextBox)sender;
            if (!EsEnteroValido(textboxEdad.Text))
            {
                MessageBox.Show("Ingrese valores correctos para la edad",
                "Error edad", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textboxEdad.Clear();
            }
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBoxEstatura = (TextBox)sender;
            if (!EsFlotanteValido(textBoxEstatura.Text))
            {
                MessageBox.Show("Ingrese valores correctos para la estatura",
                "Error Estatura", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textBoxEstatura.Clear();
            }
        }

        private bool EsFlotanteValido(string valor)
        {
            float resultado;
            return float.TryParse(valor, out resultado);
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            if (input.Length > 10)
            {
                if (!EsEnteroValidoDe10Digitos(input))
                {
                    textBox.BackColor = Color.Red;
                }
            }
            else if (!EsEnteroValidoDe10Digitos(input))
            {
                textBox.BackColor = Color.Yellow;
            }
            else
            {
                textBox.BackColor = Color.SeaGreen;
            }
        }

        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
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
            string datos = $"Nombres: {nombre}\r\n Apellidos: {apellidos}\r\n " + $"Edad: {edad}\r\nEstatura: {estatura}\r\n Telefono: {telefono}\r\n" + $"Genero: {genero}";
            MessageBox.Show("Datos guardados Correctamente: \r\n " + datos, "Información -Actividad 03", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Programacion avanzada.txt";
            bool ArchivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
            {
                if (ArchivoExiste)
                {
                    escritor.WriteLine();
                }
                escritor.WriteLine(datos);
            }
            MessageBox.Show("Datos guardados Correctamente: \r\n " + datos, "Información -Actividad 03", MessageBoxButtons.OK, MessageBoxIcon.Information);
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