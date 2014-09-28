using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationPlanetApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void planetNumberButton_Click(object sender, EventArgs e)
        {
            string Planet = planetNameComboBox.Text;
            if (Planet == "Planet")
            {
                MessageBox.Show("your planet number is 1");
            }
            else if (Planet == "Saturn")
            {
                MessageBox.Show(" your planet no is 2");
            }
            else if (Planet == "Mars")
            {
                MessageBox.Show("your planet no is 3");
            }
            else
                MessageBox.Show("invalid input");
                
        }
    }
}
