using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace culori
{
    
    public partial class Form1 : Form
    {
        int r, g, b;

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        public Form1()
        {
            InitializeComponent();
            r = g = b = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
           
            Form1.ActiveForm.BackColor = Color.FromArgb(r, g, b);
            r++;
            if (r == 255) { r = 0; b++; g ++; }
            if (g == 255) { b++; g = 0; r = 0; }
            if (b == 255) { b=0; g = 0; r = 0; }

        }
    }
}
