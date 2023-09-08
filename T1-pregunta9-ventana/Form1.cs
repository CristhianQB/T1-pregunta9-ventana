using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_pregunta9_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puntos = int.Parse(txtb1.Text);

            if (puntos <= 999)
            {
                lbl.Text = "Bronce";
            }
            else if (puntos >= 1000 && puntos <= 4999)
            {
                lbl.Text = "Plata";
            }
            else if (puntos >= 5000 && puntos <= 9999)
            { 
                lbl.Text = "Oro";
            }
            else
            {
                lbl.Text = "Platino";
            }

        }
    }
}
