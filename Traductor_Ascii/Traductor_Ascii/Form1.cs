using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traductor_Ascii
{
    public partial class Form1 : Form
    {
        ArrayList arreglo = new ArrayList();
        ArrayList arreglo1 = new ArrayList();
        int tipo = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_Traducir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_A_Traducir.Text))
            {
                if (tipo == 1)
                {
                    traduceAscii_Caracter();
                } else if (tipo == 2)
                {
                    traduceCaracter_Ascii();
                }
            }
            else
            {
                lbl_Alert.Text = "Ingrese algún texto";
            }
        }


        private void traduceCaracter_Ascii()
        {
            string caracter = "", mensaje="";
            arreglo1.Clear();
            foreach (string item in arreglo)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    caracter = item.Substring(i, 1);
                    mensaje = mensaje + Asc(caracter.ToString()) + " ";
                    //mensaje = mensaje + Encoding.ASCII.GetBytes(caracter.ToString())[0] + " ";
                    arreglo1.Add(mensaje);
                    //Console.WriteLine();
                }
            }
            foreach (var item in arreglo1)
            {
                lbl_Traducido.Text = item.ToString();
            }
        }

        private void traduceAscii_Caracter()
        {
            string[] caracter;
            string mensaje = "";
            int numero = 0;
            byte bt;
            char letra;
            arreglo1.Clear();
            foreach (string item in arreglo)
            {
                for (int i = 0; i < item.Length-1; i++)
                {
                    caracter = item.ToString().Split(' ');
                    try
                    {
                        numero = Convert.ToInt16(caracter[i]);
                    }
                    catch (FormatException)
                    {
                        break;
                    }
                   
                    letra = (char)numero;
                    Console.WriteLine(i);
                    mensaje = mensaje + Encoding.GetEncoding(437).GetString(new byte[] { Convert.ToByte(numero) });
                    arreglo1.Add(mensaje);
                }
            }
            foreach (var item in arreglo1)
            {
                lbl_Traducido.Text = item.ToString();
            }
        }
        
        private void importarArchivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string linea = "";
            OpenFileDialog dialog = new OpenFileDialog();
            Encoding enc = System.Text.Encoding.UTF7;
            dialog.Title = "Seleccionar fichero";
            dialog.Filter = "Documentos de texto (*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader archivo = new StreamReader(dialog.FileName, enc);
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine().ToString();
                    arreglo.Add(linea);
                }
            }
            foreach (var item in arreglo)
            {
                txt_A_Traducir.Text = item.ToString();
            }
        }
        private void exportarArchivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_Traducido.Text))
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "prueba.txt";
                // filtros
                save.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter w = new StreamWriter(save.FileName);

                    w.WriteLine(lbl_Traducido.Text);
                    w.Close();
                }
            }
            else lbl_Alert.Text = "Ingrese algún texto";
        }

        private void aSCIIACaracterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = 1;
            accionesToolStripMenuItem.Enabled = true;
            lbl_Alert.Enabled = true;
            lbl_Traducido.Enabled = true;
            txt_A_Traducir.Enabled = true;
            btn_Traducir.Enabled = true;
        }
        private void caracterAASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = 2;
            accionesToolStripMenuItem.Enabled = true;
            lbl_Alert.Enabled = true;
            lbl_Traducido.Enabled = true;
            txt_A_Traducir.Enabled = true;
            btn_Traducir.Enabled = true;
        }
        public static int Asc(string s)
        {
            return Encoding.GetEncoding(437).GetBytes(s)[0];
        }
        
    }
}
