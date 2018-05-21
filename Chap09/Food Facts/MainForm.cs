using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_6_Food_Facts
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void displaybutton1_Click(object sender, EventArgs e)
        {
            NutritionForm nutriForm = new NutritionForm();
            if (banannaradioButton1.Checked)
            {
                nutriForm.label5.Text = "1 Bananna";
                nutriForm.label6.Text = "100";
                nutriForm.label7.Text = "0.4";
                nutriForm.label8.Text = "27";
            }
            else if (popcornradioButton2.Checked)
            {
                nutriForm.label5.Text = "1 cup air-popped popcorn";
                nutriForm.label6.Text = "31";
                nutriForm.label7.Text = "0.4";
                nutriForm.label8.Text = "6";
            }
            else if (muffinradioButton3.Checked)
            {
                nutriForm.label5.Text = "1 Large blueberry Muffin";
                nutriForm.label6.Text = "385";
                nutriForm.label7.Text = "9";
                nutriForm.label8.Text = "67";
            }
            nutriForm.ShowDialog();
        
        }
         
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
