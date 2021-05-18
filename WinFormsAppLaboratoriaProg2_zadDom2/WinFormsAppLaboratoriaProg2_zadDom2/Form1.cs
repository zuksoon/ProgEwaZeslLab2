using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLaboratoriaProg2_zadDom2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (rbtnMala.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name, 9f, textBox1.Font.Style, textBox1.Font.Unit);
            }
            if (rbtnDuza.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name, 12f, textBox1.Font.Style, textBox1.Font.Unit);
            }
            if (rbtnBardzoDuza.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name, 15f, textBox1.Font.Style, textBox1.Font.Unit);
            }
            if (checkBoxPogrubienie.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular); // powrót do regulara bez tego nie wraca jak np underline
            }
            if (checkBoxPodkreslenie.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
            if (checkBoxPochylenie.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (rbtnNiebieski.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
            if (rbtnCzerwony.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (rbtnPomaranczowy.Checked)
            {
                textBox1.ForeColor = Color.Orange;
            }
        }
    }
}
