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
            //MessageBox.Show(Calc.AtHolyLiten(10, 10, 10).ToString());
            MessageBox.Show(Calculate.Price(1, 1, 1, 0, 0, 6, 0));
        }

        private void reset_Click(object sender, EventArgs e)
        {
            
            radioAgder.Checked = false;
            radioMandal.Checked = false;
            radioVennesla.Checked = false;
            resultBox.Text = Calc.AtDagLiten(10, 7, 0).ToString();
            
        }

        private void radioAgder_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
