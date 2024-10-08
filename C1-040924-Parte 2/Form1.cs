using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace C1_040924_Parte_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string appPath = "";
        string[] data = ["Hola mundo", "Esto es un ejemplo", "De c�mo escribir un archivo"];

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                appPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(this.appPath, "datos.txt");
            if (!File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                using (StreamWriter archivoSalida = new StreamWriter(fileName))
                {
                    // Se recorre la colecci�n de cadenas de caracteres y se escribe al archivo
                    foreach (string line in data)
                        archivoSalida.WriteLine(line);
                }
            }
            else
            {
                // Se a�aden datos al archivo ya que existe, para eso se establece el segundo par�metro
                using (StreamWriter archivoSalida = new StreamWriter(fileName, true))
                {
                    archivoSalida.WriteLine("Nuevos datos en una nueva l�nea");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileBuscar.ShowDialog() == DialogResult.OK) ;
            {
                // Se establece el nombre del archivo a leer
                string fileName = openFileBuscar.FileName;
                // Se lee el archivo y se muestra en el control label1
                using (StreamReader archivoEntrada = new StreamReader(fileName))
                {
                    label1.Text = archivoEntrada.ReadToEnd();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {

            }
            
            
            
            // que el contenido de textBox1 se escriba en el archivo datos.txt
            string fileName = Path.Combine(this.appPath, "datos.txt");
            if (!File.Exists(fileName))
            {
                using (StreamWriter archivoSalida = new StreamWriter(fileName))
                {
                    archivoSalida.WriteLine(textBox1.Text);
                }
            }
            else
            {
                using (StreamWriter archivoSalida = new StreamWriter(fileName, true))
                {
                    archivoSalida.WriteLine(textBox1.Text);
                }
            }

            
        }
    }
}
