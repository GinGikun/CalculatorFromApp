using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFromApp
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

        private void Operasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = Operasi.Text;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Hasil();

        }

        private void Hasil()
        {
            double op1, op2, resault;

            op1 = Convert.ToDouble(txtNilaiA.Text);
            op2 = Convert.ToDouble(txtNilaiB.Text);

            switch (Operasi.SelectedItem.ToString())
            {
                case "Penambahan":
                    resault = op1 + op2;
                    lstHasil.Text = resault.ToString();
                    break;
                case "Pengurangan":
                    resault = op1 - op2;
                    lstHasil.Text = resault.ToString();
                    break;
                case "Perkalian":
                    resault = op1 * op2;
                    lstHasil.Text = resault.ToString();
                    break;
                case "Pembagian":
                    resault = op1 / op2;
                    lstHasil.Text = resault.ToString();
                    break;

            }

        }
    }
}
