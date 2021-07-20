using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma_dos_numeros
{
    public partial class SOMA : Form
    {
        public SOMA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma =  0;
            for (int i = 1; i <= 1000; i++)
            {
                soma += 1;
            }
            MessageBox.Show("O resultado é: " + soma);
        }
    }
}
