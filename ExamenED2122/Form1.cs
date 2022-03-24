using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenED2122
{
    public partial class Form1 : Form
    {
        double cantidadTotalrlp2122;
        double temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double importerlp2122 = Convert.ToDouble(txtImporte.Text);
            double ivaDelImporterlp2122;
            double IVArlp2122 = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVArlp2122 = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVArlp2122 = 0.04;
            ivaDelImporterlp2122 = importerlp2122 * IVArlp2122; // Calculamos el importe con IVA
            cantidadTotalrlp2122 = importerlp2122 + ivaDelImporterlp2122 + temp;// Se lo añadimos a la cantidad total
            temp = cantidadTotalrlp2122;
            txtResultado.Text = Convert.ToString(importerlp2122);
        }
        
        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalrlp2122);
        }
    }
}
