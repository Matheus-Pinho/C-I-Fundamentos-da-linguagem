using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculando_Bhaskara
{
    public partial class Bhaskara : Form
    {
        public Bhaskara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 5;
            int c = 2;

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("O resultado é: " + a1);
            MessageBox.Show("O resultado é: " + a2);
        }

        private void Bhaskara_Load(object sender, EventArgs e)
        {

        }
    }
}
