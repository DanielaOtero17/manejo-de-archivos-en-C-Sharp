using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security;


namespace aplicacion
{
    public partial class Form1 : Form
    {

        private OpenFileDialog chooser;
        private Button selectButton;
        public Form1()
        {
            InitializeComponent();
          
             chooser = new OpenFileDialog();
            chooser.FileName = "Seleccione un Archivo de Texto";
            chooser.Filter = "Archivos de Texto(*.txt)|*.txt";
            chooser.Title = "Abrir un Archivo de Texto";

            selectButton = new Button();
            selectButton.Size = new Size(100, 20);
            selectButton.Location = new Point(15, 15);
            selectButton.Text = "Select file";

            //iniciamos el método BtnAbrirArchivo_Click.
            selectButton.Click += new EventHandler(BtnAbrirArchivo_Click);
            //Controls.Add(selectButton);
        }

        public void BtnAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (chooser.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = chooser.FileName;
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        StreamReader sr = new StreamReader(fs);

                        txtNombreCaf.Text = sr.ReadLine() ;
                        txtNoDeIncio.Text = sr.ReadLine();
                        txtNoDeFinal.Text = sr.ReadLine();
                        txtCuDesPorDia.Text = sr.ReadLine();
                        txtNumEsPorDia.Text = sr.ReadLine();

                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        } 

        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {

          
            String nombre = txtNombreCaf.Text;
            String numCuNoDesechablesInicio = txtNoDeIncio.Text;
            String numCuNoDesechablesFinal = txtNoDeFinal.Text;
            String cubiertosDesechablesPorDia = txtCuDesPorDia.Text;
            String numeroPromedioEstudiantesPorDia = txtNumEsPorDia.Text;
            //fijamos dondevamos a crear el archivo 
            StreamWriter escrito = File.CreateText(nombre+".txt");

            //escribimos. 
            escrito.Write(nombre.ToString());
            escrito.WriteLine("");
            escrito.Write(numCuNoDesechablesInicio.ToString());
            escrito.WriteLine("");
            escrito.Write(numCuNoDesechablesFinal.ToString());
            escrito.WriteLine("");
            escrito.Write(cubiertosDesechablesPorDia.ToString());
            escrito.WriteLine("");
            escrito.Write(numeroPromedioEstudiantesPorDia.ToString());

            escrito.Flush();
            //Cerramos 
            escrito.Close();
            //Vaciamos 
            txtNombreCaf.Text = "";
            txtNoDeIncio.Text = "";
            txtNoDeFinal.Text = "";
            txtCuDesPorDia.Text = "";
            txtNumEsPorDia.Text = "";

            MessageBox.Show("El archivo se ha guardado con exito como:"+ nombre + ".txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void TxtNombreCaf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
