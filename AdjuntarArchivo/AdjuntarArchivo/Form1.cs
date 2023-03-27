using System;
using AdjuntarArchivo.Cache;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Data;
using System.Threading.Tasks;

namespace AdjuntarArchivo
{
    public partial class LeerArchivo : Form
    {
        public LeerArchivo()
        {
            InitializeComponent();
            richTextBox2.Hide();
            rutaArchivo.Hide();
            botonAdjuntar.Hide();
            leerTextoIng.Hide();

        }

        string textoCache = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresarTexto_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void opcionIngDatos_Enter(object sender, EventArgs e)
        {
            if (adjuntarDoc.Checked == true)
            {
                richTextBox2.Hide();
                rutaArchivo.Show();
                botonAdjuntar.Show();
                leerTextoIng.Hide();
            }
            else if (ingresarTexto.Checked == true)
            {
                richTextBox2.Show();
                rutaArchivo.Hide();
                botonAdjuntar.Hide();
                leerTextoIng.Show();
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void botonAdjuntar_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Buscar tu archivo";
            openFileDialog1.ShowDialog();
            string Texto = openFileDialog1.FileName;
            string ext = Path.GetExtension(Texto);
           

            if (File.Exists(openFileDialog1.FileName))
            {

                TextReader leer = new StreamReader(Texto);
                richTextBox1.Text = leer.ReadToEnd();
                leer.Close();
            }


            Cache.Cache.GetCache().agregarContenido(Texto);
            rutaArchivo.Text = Texto;
        }

        private void adjuntar_CheckedChanged()
        {

        }

        private void adjuntarDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (adjuntarDoc.Checked == true)
            {
                richTextBox2.Hide();
                rutaArchivo.Show();
                botonAdjuntar.Show();
                leerTextoIng.Hide();
            }
        }

        private void ingresarTexto_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ingresarTexto.Checked == true)
            {
                richTextBox2.Show();
                rutaArchivo.Hide();
                botonAdjuntar.Hide();
                leerTextoIng.Show();
            }
        }

        private void leerTextoIng_Click(object sender, EventArgs e)
        {
            string lineas = richTextBox2.Text;
            string nuevo = String.Empty;
            if (lineas.Length > 0)
            {
                Cache.Cache.GetCache().agregarContenido(lineas);
            }
            richTextBox1.Text = lineas;
        }
    }
}