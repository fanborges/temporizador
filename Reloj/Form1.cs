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
    public partial class Form1 : Form
    {
        Boolean cuentatiempo = false;
        int contador, hr, min, sec, total, aux;
        public Form1()
        {
            InitializeComponent();
            CadenaUnicode cadena = new CadenaUnicode();
           // cadena.Show();
            contador = hr = min = sec = total = aux = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void hora()
        {
            lbl_hora.Text = System.DateTime.Now.ToLongTimeString() ;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            hora();
            if (cuentatiempo ==true)
            {
                
                contador++;
               
                lbl_total.Text = Convert.ToString(aux);
                aux--;

            }
            if (cuentatiempo == false)
            {
                contador = 0;

            }

            if (contador > total && total != 0)
            {
                Console.Beep(5000, 1000);
                lbl_total.Text = "0";

            }
                       
        }

        private void txt_actividad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
           
            lbl_total.Text = "0000";
            contador = hr = min = sec = total = aux = 0;
            cuentatiempo = true;
            if (cb_hr.SelectedIndex != -1)
            {
                hr = (cb_hr.SelectedIndex) * 3600;
                
                
            }
            else { hr = 0; };
            if (cb_min.SelectedIndex != -1)
            {
               
                min = (cb_min.SelectedIndex) * 60;

            }else{min=0;};

            if (cb_secs.SelectedIndex != -1)
            {
                sec = cb_secs.SelectedIndex;
              
                
                
            }else{sec =0;};

            total = hr + min + sec;
            aux = total;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cuentatiempo = false;            
            lbl_total.Text = "0000";
            contador = hr = min = sec = total = aux = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





      
    }
}
