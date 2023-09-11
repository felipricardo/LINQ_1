using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produto;
        Dictionary<string, string> lista_estados;
        
        public Form1()
        {
            InitializeComponent();

            #region Lista de Nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Julia");
            lista_nomes.Add("Felipe");
            #endregion

            #region Lista de Numeros
            lista_numeros = new List<string>();
            lista_nomes.Add("Julia");
            lista_nomes.Add("Felipe");
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
