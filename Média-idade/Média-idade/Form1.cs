using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Média_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeLuciano = 40;
            int idadeLeandro = 38;
            int idadeCris = 34;
            int idadeMatheus = 23;

            double media = (idadeLuciano + idadeLeandro + idadeCris + idadeMatheus) / 4;

            MessageBox.Show("A Média das idades é: " + media);

            
        }
    }
}
