using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorsionalVibrationCalculationOfaShaft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double k;
        double j;
        double f;
        private void button1_Click(object sender, EventArgs e)
        {
            double ps;
            double sho;
            double shi;
            double shL;
            double g;
            double mJ;
            double.TryParse(txtDen.Text, out ps);
            double.TryParse(txtSho.Text, out sho);
            double.TryParse(txtShi.Text, out shi);
            double.TryParse(txtShL.Text, out shL);
            double.TryParse(txtG.Text, out g);
            double.TryParse(txtJ.Text, out mJ);

            if (txtDen.Text == "" || txtSho.Text == "" || txtShi.Text == "" || txtShL.Text == "" || txtG.Text == "" || txtJ.Text == "")
            {
                MessageBox.Show("Please enter values!", "Warning!");
            }
            else
            {
                k = (Math.PI / 2) * (Math.Pow((sho / 2), 4) - Math.Pow((shi / 2), 4));
                j = (ps * Math.PI * ((Math.Pow(sho,2)- Math.Pow(shi, 2))/4) / 2) * (Math.Pow((shi / 2), 2) + Math.Pow((sho / 2), 2));
                f = (1 / (2 * Math.PI)) * Math.Sqrt(((g * 1000000000) * k) / ((mJ + (j / 3)) * shL));
                k= Math.Round(k, 2);
                lbK.Text = Convert.ToString(k);
                j = Math.Round(j, 2);
                lbJ.Text = Convert.ToString(j);
                f = Math.Round(f, 2);
                lbF.Text = Convert.ToString(f);

                hz1.Visible = true;
                hz2.Visible = true;
                hz3.Visible = true;




            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hz1.Visible = false;
            hz2.Visible = false;
            hz3.Visible = false;
            lbF.Text = "";
            lbJ.Text = "";
            lbK.Text = "";
            txtDen.Text = "";
            txtSho.Text = "";
            txtShi.Text = "";
            txtShL.Text = "";
            txtG.Text = "";
            txtJ.Text = "";
        }

        private void txtDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtDen.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtDen.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtDen.Text.StartsWith("0") && !txtDen.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtSho_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtSho.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtSho.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtSho.Text.StartsWith("0") && !txtSho.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtShi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtShi.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtShi.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtShi.Text.StartsWith("0") && !txtShi.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtShL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtShL.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtShL.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtShL.Text.StartsWith("0") && !txtShL.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtG.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtG.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtG.Text.StartsWith("0") && !txtG.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtJ.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtJ.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtJ.Text.StartsWith("0") && !txtJ.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
            //skocak
        }
    }
}
