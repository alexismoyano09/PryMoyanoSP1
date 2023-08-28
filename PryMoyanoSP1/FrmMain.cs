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

namespace PryMoyanoSP1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("miArchivo", true);
                MessageBox.Show("Archivo Creado");
            }
            catch (Exception)
            {

                MessageBox.Show("Archivo ya creado");
            }

        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("miArchivo", true);

                swCrearArchivo.WriteLine(txttextito.Text);

                swCrearArchivo.Close();

                MessageBox.Show("Almacenado");
                txttextito.Text = "";
                txttextito.Focus();
            }
            catch (Exception ex )
            {

                MessageBox.Show("Error Fatal" + ex.Message);

            }
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            StreamReader SrManejodeArchivo = new StreamReader("MiArchivo");
            
            while (SrManejodeArchivo.EndOfStream == false)
            {
                txttextito.Text += SrManejodeArchivo.ReadLine() + Environment.NewLine;
            }

            SrManejodeArchivo.Close();


        }
    }
}
