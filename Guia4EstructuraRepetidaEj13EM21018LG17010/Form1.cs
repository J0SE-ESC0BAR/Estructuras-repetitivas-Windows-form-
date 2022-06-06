using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4EstructuraRepetidaEj13EM21018LG17010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //Lipiar tabla para que no se repitan los datos
            dgvTablaDeNum.Rows.Clear();
            for (int i = 100; i < 1000; i++)
            {
                //saca el primer dijito del numero de 3 cifras
                int a1 = i/100;
                //saca el segundo dijito del numero de 3 cifras
                int b1 = (i / 10) - (a1 * 10);
                //saca el tercer dijito del numero de 3 cifras
                int c1 = i * (a1 * 100 + b1 * 10);
                //eleva los 3 dijitos al cuadrado, los suma y los divide entre 3
                double n = (Math.Pow(a1, 2) + Math.Pow(b1, 2) + Math.Pow(c1, 2) / 3);
                //evalua si el resultado es entero o no
                if (n % 2 == 0)
                {
                    //Colocar la informacion en la tabla
                    dgvTablaDeNum.Rows.Add(i.ToString());
                }
            }
        }
    }
}
