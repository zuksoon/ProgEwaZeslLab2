using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLaboratoriaProg2_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sColor = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoCzerwony.Checked)
            {
                sColor = rdoCzerwony.Text;
            }

            if (rdoZielony.Checked)
            {
                sColor = rdoZielony.Text;
            }

            if (rdoZielony.Checked)
            {
                sColor = rdoZielony.Text;
            }

            MessageBox.Show("Twój ulubiony kolor to: " + sColor);
        }
    }
}
