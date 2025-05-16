using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tercera_unidad_3_actividad_1
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

        private void BTNcrearfichero_Click(object sender, EventArgs e)
        {
           //StreamWriter es la clase que representa a un fichero de texto 
           //en el que podemos escribir informacion 
           //El fichero de texto lo creamos con el metodo ( estatico ) CreateText que pertenece a la clase file 
           //Para escribir en el fichero , empleamos write y writeline 
           //Close para cerrar el archivo , o podria quedar algun dato sin guardar
            
            StreamWriter fichero;
            fichero = File.CreateText("fichero1.txt");
            fichero.WriteLine("  ");
            fichero.Write(" primer paso ");
            fichero.Write("\r\n");
            fichero.WriteLine("  ");
            fichero.Close();         
        
        
        
        }

        private void BTNforma2decrear_Click(object sender, EventArgs e)
        {
            using (StreamWriter fichero = new StreamWriter("fichero1.txt"))
            {
                fichero.WriteLine("Este codigo es mas compacto");
                fichero.WriteLine("jesus");
                fichero.WriteLine("carlos");
            }
        }

        private void BTNleerarchivo1_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            linea = fichero.ReadLine();
            Console.WriteLine(linea);
           // Console.WriteLine(fichero.ReadLine());
           //Console.WriteLine(fichero.ReadLine());
            fichero.Close();
        }

        private void BTNleerFinal_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            fichero = File.OpenText("fichero1.txt");
            while(!fichero.EndOfStream)
                Console.WriteLine(fichero.ReadLine());
            fichero.Close();
            

            
        }

        private void BTNleerarchivodowhile_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            do 
            { 
             linea = fichero.ReadLine();
                if (linea !=  null)
                    Console.WriteLine(linea);
            
            }
            while(linea != null);
            fichero.Close();
        }

        private void BNTmodificar_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;
            fichero = File.CreateText("fichero1.txt");
            fichero.WriteLine("primera prueba");
            fichero.Close();

            fichero = File.AppendText("fichero1.txt");
            fichero.WriteLine("Segunda prueba");
            fichero.Close();
           
        }

        private void BtnAbrir2_Click(object sender, EventArgs e)
        {
            using (StreamReader fichero = File.OpenText("fichero1.txt"))
            {
                string linea;
                linea = fichero.ReadLine();
                Console.WriteLine(linea);
                Console.WriteLine(fichero.ReadLine());
                Console.WriteLine(fichero.ReadLine());
            }
        }
    }
}
