using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reloj
{
    public partial class CadenaUnicode : Form
    {
        public CadenaUnicode()
        {
            InitializeComponent();
        }

        private void btn_unicode_Click(object sender, EventArgs e)
        {
            string salida = "";
            string input = txt_entrada.Text;

            var result = input.Select(t => string.Format("U+{0:X4} ", Convert.ToUInt16(t))).ToList();
            for (int i = 0; i < result.Count; i++)
            {

                salida += "\\" + result[i];
            
            }

            txt_entrada.Text = salida;
        }
    }
}
