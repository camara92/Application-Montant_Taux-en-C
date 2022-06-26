using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_CAMARA
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          double moachat= double.Parse(textBox1.Text);
            double taux = 0;
            double montantpayer;
            double pourcentage; 
            if(moachat > 5000)
            {
                taux = 0.2;

            }
            else if(moachat > 4000){
                taux = 0.15; 
            }else if (moachat > 3000)
            {
                taux = 0.1;
            }
            else if(moachat>1000)
            {
                taux = 0.05;
            }
            montantpayer = moachat - moachat * taux;
            pourcentage = taux * 100; 

            textBox2.Text = pourcentage+"%";
            textBox3.Text = montantpayer.ToString(); 


        }
    }
}
