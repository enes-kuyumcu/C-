using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_4
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
        
       int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int mısır, kola, su, bilet;
            mısır = Convert.ToInt16(txtmisir.Text);
            kola = Convert.ToInt16(txtkola.Text);
            su = Convert.ToInt16(txtsu.Text);
            bilet = Convert.ToInt16(txtbilet.Text);

            toplam = mısır * 4 + kola * 2 + su * 1 + bilet * 8;
            label15.Text = toplam.ToString();

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString();

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtkola.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            label15.Text = "00";
            txtmisir.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblkasa.Text = "00";
            txtmisir.Focus();
           
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            



        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int yapılan_odeme = 0;
            int para_ustu = 0;
            int mısır, kola, su, bilet;
            mısır = Convert.ToInt16(txtmisir.Text);
            kola = Convert.ToInt16(txtkola.Text);
            su = Convert.ToInt16(txtsu.Text);
            bilet = Convert.ToInt16(txtbilet.Text);

            toplam = mısır * 4 + kola * 2 + su * 1 + bilet * 8;
            label15.Text = toplam.ToString();
            
            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString();

           yapılan_odeme = Convert.ToInt16(textbox1.Text);
           para_ustu = toplam  - yapılan_odeme;
           label12.Text = para_ustu.ToString();
         

        
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }  


       
         

        }

    }

