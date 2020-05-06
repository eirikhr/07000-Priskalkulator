using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priskalkulator
{
    public partial class HovedVindu : Form
    {
        public HovedVindu()
        {
            InitializeComponent();
        }
                
        private void calculate_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calc.Mt.Dag.Liten(8, 13, 0, 0).ToString();
            textBox2.Text = Calc.Mt.Kveld.Liten(8, 13, 0, 0).ToString();
            textBox3.Text = Calc.Mt.Lørdag.Liten(8, 13, 0, 0).ToString();
            textBox4.Text = Calc.Vt.Helg.Liten(8, 13, 0, 0).ToString();
            textBox5.Text = Calc.Vt.Holy.Liten(8, 13, 0, 0).ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            
            radioAgder.Checked = false;
            radioMandal.Checked = false;
            radioVennesla.Checked = false;
            resultBox.Text = "0";
            // resultBox.Text = Calc.AtDagLiten(10, 7, 0).ToString();

            // Testbokser
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            

        }

        private void radioAgder_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioAgder.Checked)
            {
                tidAgder.Visible = true;
                tidAgder.BringToFront();
                UpdateZOrder();

            }
            if (!radioAgder.Checked)
            {
                tidAgder.Visible = false;
                tidAgder.SendToBack();
                UpdateZOrder();
            }
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(resultBox.Text);
        }

        private void radioVennesla_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVennesla.Checked)
            {
                tidVennesla.Visible = true;
                tidVennesla.BringToFront();
                UpdateZOrder();
            }
            if (!radioVennesla.Checked)
            {
                tidVennesla.Visible = false;
                tidVennesla.SendToBack();
                UpdateZOrder();
            }
        }

        private void radioMandal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMandal.Checked)
            {
                tidMandal.Visible = true;
                tidMandal.BringToFront();
                UpdateZOrder();
            }                
            
            if (!radioMandal.Checked)
            {
                tidMandal.Visible = false;
                tidMandal.SendToBack();
                UpdateZOrder();
            }
                
        }
    }
}
