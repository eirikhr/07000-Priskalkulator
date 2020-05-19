using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        // Kalkuleringslogikk        
        private void calculate_Click(object sender, EventArgs e)
        {      

            // Sjekke om det er gyldige verdier i Tekstboksene.
            if (string.IsNullOrEmpty(kmBox.Text))
                kmBox.Text = "0";
            if (string.IsNullOrEmpty(minBox.Text))
                minBox.Text = "0";
            if (string.IsNullOrEmpty(fremBox.Text))
                fremBox.Text = "0";
            if (string.IsNullOrEmpty(tilBox.Text))
                tilBox.Text = "0";

            float result = 0f;

            string kmstr = kmBox.Text;
            string minstr = minBox.Text;
            string fremstr = fremBox.Text;
            string tilstr = tilBox.Text;

            float km = float.Parse(kmstr);
            float min = float.Parse(minstr);
            float frem = float.Parse(fremstr);
            float til = float.Parse(tilstr);
            
            void writeResult()
            {
                int output = (int)Math.Round(result);
                resultBox.Text = output.ToString();
            }

            if (radioAtDag.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.At.Dag.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.At.Dag.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.At.Dag.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioAtKveld.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.At.Kveld.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.At.Kveld.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.At.Kveld.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioAtHoly.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.At.Hellig.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.At.Hellig.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.At.Hellig.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioVtDag.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Vt.Dag.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Vt.Dag.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Vt.Dag.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioVtKveld.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Vt.Kveld.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Vt.Kveld.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Vt.Kveld.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioVtHelg.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Vt.Helg.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Vt.Helg.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Vt.Helg.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioVtHoly.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Vt.Holy.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Vt.Holy.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Vt.Holy.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioMtDag.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Mt.Dag.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Mt.Dag.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Mt.Dag.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioMtKveld.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Mt.Kveld.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Mt.Kveld.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Mt.Kveld.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioMtLørdag.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Mt.Lørdag.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Mt.Lørdag.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Mt.Lørdag.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioMtHelg.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Mt.Helg.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Mt.Helg.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Mt.Helg.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else if (radioMtHoly.Checked)
            {
                if (radioLiten.Checked)
                    result = Calc.Mt.Holy.Liten(km, min, frem, til);
                else if (radioMedium.Checked)
                    result = Calc.Mt.Holy.Medium(km, min, frem, til);
                else if (radioStor.Checked)
                    result = Calc.Mt.Holy.Stor(km, min, frem, til);
                else
                    radioMissing();
                writeResult();
            }
            else
            {
                radioMissing();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Radio-buttons            
            clearAllBoxes();

            resultBox.Clear();
            // Tekstbokser
            kmBox.Clear();
            minBox.Clear();
            fremBox.Clear();
            tilBox.Clear();
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
            clearSomeBoxes();
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            
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
            clearSomeBoxes();
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
            clearSomeBoxes();
        }

        private void fremLabel_Click(object sender, EventArgs e)
        {

        }

        private void kmBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Godtar 0-9, backspace og .
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // Sjekker at det bare er èn decimal.
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void minBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Godtar 0-9, backspace og .
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // Sjekker at det bare er èn decimal.
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void fremBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Godtar 0-9, backspace og .
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // Sjekker at det bare er èn decimal.
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void tilBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tilBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Godtar 0-9, backspace og .
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // Sjekker at det bare er èn decimal.
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void clearAllBoxes()
        {
            foreach (RadioButton radio in taxiLagBox.Controls.OfType<RadioButton>().ToList())
                if (radio.Checked)
                {
                    radio.Checked = false;
                    break;
                }
            foreach (RadioButton radio in paxBox.Controls.OfType<RadioButton>().ToList())
                if (radio.Checked)
                {
                    radio.Checked = false;
                    break;
                }
            clearSomeBoxes();
        }
        
        private void clearSomeBoxes()
        {
            foreach (RadioButton radio in tidMandal.Controls.OfType<RadioButton>().ToList())
                if (radio.Checked)
                {
                    radio.Checked = false;
                    break;
                }
            foreach (RadioButton radio in tidAgder.Controls.OfType<RadioButton>().ToList())
                if (radio.Checked)
                {
                    radio.Checked = false;
                    break;
                }
            foreach (RadioButton radio in tidVennesla.Controls.OfType<RadioButton>().ToList())
                if (radio.Checked)
                {
                    radio.Checked = false;
                    break;
                }
        }

        private void radioMissing()
        {
            MessageBox.Show("Taxilag, antall passasjerer og tidspunkt må være valgt.");
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultBox.Text))
            {
                Clipboard.SetText(resultBox.Text);
                int lengdems = 1500;
                toolCopy.Show("Kopiert!", pictureBox1, lengdems);
            }
                

        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void takstinformasjonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Takster oppdatert:\n06.06.2020.");
        }

        private void versjonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v1.0 - 19.05.2020");
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HovedVindu_Load(object sender, EventArgs e)
        {

        }
    }
}
