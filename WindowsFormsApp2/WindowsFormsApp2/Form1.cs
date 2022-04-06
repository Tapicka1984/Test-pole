using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int[] pole = new int[250];
        int promenadopole = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                Random random = new Random();
                int r = random.Next(32, 127);
                pole[promenadopole] = (char)r;
                label4.Text = promenadopole.ToString();
                promenadopole++;


            } catch(Exception ex)
            {
                MessageBox.Show("nekde nastala chyba");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (promenadopole > 0)
            {

                listBox1.Items.Add((char)pole[promenadopole]);
                int ukoldva = (char)pole[promenadopole];
                int dvojteW = pole[promenadopole];
                if (((ukoldva > 48) && (ukoldva < 57)) || ((ukoldva > 97) && (ukoldva < 122)))
                {
                    listBox2.Items.Add((char)pole[promenadopole]);
                }
                promenadopole--;
            }
        }
    }
}
