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
        public Form1()
        {
            InitializeComponent();
        }

        private void importarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string linea = "";
            OpenFileDialog dialog = new OpenFileDialog();
            Encoding enc = System.Text.Encoding.UTF7;
            dialog.Title = "Seleccionar fichero";
            dialog.Filter = "Documentos de texto (*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader archivo = new StreamReader(dialog.FileName, enc);
                while (!archivo.EndOfStream) {
                    linea = @archivo.ReadLine().ToString() + Environment.NewLine;
                    arreglo.Add(linea);
                }
            }
            foreach (var item in arreglo)
            {
                txt_A_Traducir.Text = item.ToString();
            }
        }

        private void btn_Traducir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_A_Traducir.Text))
            {
                traduce();
                arreglo.Clear();
                txt_A_Traducir.Text = null;
            }else
            {
                lbl_Alert.Text = "Ingrese algún texto";
                int cont = 0;
                while (cont !=2) {
                    cont++;
                    Thread.Sleep(1000);
                    if (cont == 2) lbl_Alert.Text = "";
                }
                
               // lbl_Alert.Text = "";
            }
        }


        private void traduce()
        {
            string caracter = "";
            foreach (string item in arreglo)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    caracter = item.Substring(i, 1);
                    Console.WriteLine(Encoding.ASCII.GetBytes(caracter.ToString())[0]);
                }
            }
        }
    }
}
