using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
               
        private void calcBtn_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int.Parse(rowBox.Text);
                }
                catch
                {
                    MessageBox.Show("Select a number of rows");
                    return;
                }
                try
                {

                    int.Parse(colBox.Text);
                }
                catch
                {
                    MessageBox.Show("Select a number of columns");
                    return;
                }
            
            
                int rows = int.Parse(rowBox.Text);
                int cols = int.Parse(colBox.Text);
                String print = "";
                
                for (int h = 0; h < cols; h++)
                {
                    print += "\tn" + h ;                    
                }
                print += "\n";


                for (int r = 1; r <= rows; r++)
                {
                    for (int c = 1; c <= cols; c++)
                    {                  
                        print += "\t" + (Math.Pow(r, c).ToString());
                    }
                    print += "\n";
                }

                MessageBox.Show(print);
            
        }

        private void clrlBtn_Click(object sender, EventArgs e)
        {
            rowBox.SelectedIndex = -1;
            colBox.SelectedIndex = -1;
        }
    }
}
