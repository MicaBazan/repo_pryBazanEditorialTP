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
using System.Text.RegularExpressions;

namespace pryBazanEditoria
{
    public partial class frmLibro : Form
    {
        String[,] matLibro = new String[21, 5];

        int Indice = 0;

        char separador = Convert.ToChar(",");

        int Contador = 0;

        public frmLibro()
        {
            InitializeComponent();
        }


        private void frmLibro_Load(object sender, EventArgs e)
        {         
            String[] vecLibros = new string[5];

            StreamReader srLibro = new StreamReader("./LIBRO.txt");

            while (!srLibro.EndOfStream)
            {
                vecLibros = srLibro.ReadLine().Split(separador);

                if(Indice < 21)
                {
                    matLibro[Indice, 0] = vecLibros[0];
                    matLibro[Indice, 1] = vecLibros[1];
                    matLibro[Indice, 2] = vecLibros[2];
                    matLibro[Indice, 3] = vecLibros[3];
                    matLibro[Indice, 4] = vecLibros[4];

                    Indice++;
                }

            }
            srLibro.Close();

            txtCodigo.Text = Regex.Replace(matLibro[0, 0], @"\t", "");
            txtNombre.Text = Regex.Replace(matLibro[0, 1], @"\t", "");
            //BuscarNombreEditorial(Convert.ToInt32(matLibro[0, 2]));
            txtEditorial.Text = Regex.Replace(matLibro[0, 2], @"\t", "");
            txtAutor.Text = Regex.Replace(matLibro[0, 3], @"\t", "");
            txtDistribuidor.Text = Regex.Replace(matLibro[0, 4], @"\t", "");

            btnAnterior.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Contador++;

            txtCodigo.Text = Regex.Replace(matLibro[Contador, 0], @"\t", "");
            txtNombre.Text = Regex.Replace(matLibro[Contador, 1], @"\t", "");
            //BuscarNombreEditorial(Convert.ToInt32(matLibro[Contador, 2]));
            txtEditorial.Text = Regex.Replace(matLibro[Contador, 2], @"\t", "");
            txtAutor.Text = Regex.Replace(matLibro[Contador, 3], @"\t", "");
            txtDistribuidor.Text = Regex.Replace(matLibro[Contador, 4], @"\t", "");

            btnAnterior.Enabled = true;

            if(Contador == matLibro.GetLength(0) - 1)
            {
                btnSiguiente.Enabled = false;
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Contador--;

            if(Contador >= 0)
            {
                txtCodigo.Text = Regex.Replace(matLibro[Contador, 0], @"\t", "");
                txtNombre.Text = Regex.Replace(matLibro[Contador, 1], @"\t", "");
                //BuscarNombreEditorial(Convert.ToInt32(matLibro[Contador, 2]));
                txtEditorial.Text = Regex.Replace(matLibro[Contador, 2], @"\t", "");
                txtAutor.Text = Regex.Replace(matLibro[Contador, 3], @"\t", "");
                txtDistribuidor.Text = Regex.Replace(matLibro[Contador, 4], @"\t", "");

                if (Contador == 0)
                {
                    btnAnterior.Enabled = false;
                }
            }
            else
            {
                btnAnterior.Enabled = true;
            }
        }


        //private void BuscarNombreEditorial(int numeroEditorialBuscando)
        //{
        //    StreamReader srEditorial = new StreamReader("./EDITORIAL.txt");

        //    while (!srEditorial.EndOfStream)
        //    {
        //        string[] vecEditorial = srEditorial.ReadLine().Split(separador);

        //        for(int pos = 0; pos < vecEditorial.Length; pos++)
        //        {

        //            vecEditorial[pos] = Regex.Replace(vecEditorial[pos], @"\t", "");
        //            //txtEditorial.Text = vecEditorial[Indice];
        //        }

        //        if(vecEditorial[0] == matLibro[numeroEditorialBuscando, 2])
        //        {
        //            matLibro[numeroEditorialBuscando, 2] = vecEditorial[1];
        //        }
        //    }

        //    srEditorial.Close();
        //}
    }
}
