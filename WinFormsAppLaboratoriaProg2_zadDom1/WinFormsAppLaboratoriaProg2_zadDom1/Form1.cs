using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLaboratoriaProg2_zadDom1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float waga;
        private void btnOblicz_Click(object sender, EventArgs e)
        {
            if(checkBoxStandardowa.Checked)
            {
                waga = float.Parse(textBox1.Text) - 100;    // dużo prościej dało by się na numeric top down bo nie trzeba się bawić w obsługę wyjątków
                labelWynik.Text = waga.ToString();
            }
            if (checkBoxIdealna.Checked)
            {
                if (rbtnMezczyzna.Checked)
                {
                    waga = (float.Parse(textBox1.Text) - 100f ) * 0.9f ;
                    labelWynik.Text = waga.ToString();
                }
                if(rbtnKobieta.Checked)
                {
                    waga = (float.Parse(textBox1.Text) - 100f ) * 0.9f ;
                    labelWynik.Text = waga.ToString();
                }
            }
        }

        private void rbtnMezczyzna_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMezczyzna.Checked)
            {
                rbtnKobieta.Checked = false;
            }
            else
            {
                rbtnKobieta.Checked = true;
            }
        }

        private void checkBoxIdealna_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIdealna.Checked)
            {
                checkBoxStandardowa.Checked = false;
            }
            else
            {
                checkBoxStandardowa.Checked = true;
            }
        }
    }
}
