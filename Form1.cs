using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YanceySubnetCalculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            maskedTextBoxNetworkIP.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void maskedTextBoxNetworkIP_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Invalid IP";
                toolTip1.Show("Not a valid IP.", maskedTextBoxNetworkIP, 0, 0, 5000);
            }
        }

        private void maskedTextBoxNetworkIP_Enter(object sender, EventArgs e)
        {
            // Place cursor at the beginning of the textbox when control is selected
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                maskedTextBoxNetworkIP.Select(0, 0);
            });

            // Disable the TabStop property so we can cycle through the textbox  
            foreach (Control c in this.Controls) { c.TabStop = false; }
        }

        private void maskedTextBoxNetworkIP_Leave(object sender, EventArgs e)
        {
            // Resets the cursor when we leave the textbox  
            maskedTextBoxNetworkIP.SelectionStart = 0;
            // Enable the TabStop property so we can cycle through the form controls again  
            foreach (Control c in this.Controls) { c.TabStop = true; }
        }

        private void maskedTextBoxNetworkIP_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("KeyDown");
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.OemPeriod)
            {
                int pos = maskedTextBoxNetworkIP.SelectionStart;
                int max = (maskedTextBoxNetworkIP.MaskedTextProvider.Length - maskedTextBoxNetworkIP.MaskedTextProvider.EditPositionCount);
                int nextField = 0;

                //MessageBox.Show(pos.ToString() + "" + max.ToString());

                for (int i = 0; i < maskedTextBoxNetworkIP.MaskedTextProvider.Length; i++)
                {
                    if (!maskedTextBoxNetworkIP.MaskedTextProvider.IsEditPosition(i) && (pos + max) >= i)
                        nextField = i;
                }
                nextField += 1;

                // We're done, enable the TabStop property again  
                if (pos == nextField)
                    maskedTextBoxNetworkIP_Leave(this, e);

                maskedTextBoxNetworkIP.SelectionStart = nextField;
            }
        }

        private void tabPageSubnet_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxNetworkIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("KeyDown");
        }

        private void maskedTextBoxNetworkIP_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           // MessageBox.Show("KeyDown");
            if (e.KeyCode == Keys.Tab)
            {
                int pos = maskedTextBoxNetworkIP.SelectionStart;
                int max = (maskedTextBoxNetworkIP.MaskedTextProvider.Length - maskedTextBoxNetworkIP.MaskedTextProvider.EditPositionCount);
                int nextField = 0;

                //MessageBox.Show(pos.ToString() + "" + max.ToString());

                for (int i = 0; i < maskedTextBoxNetworkIP.MaskedTextProvider.Length; i++)
                {
                    if (!maskedTextBoxNetworkIP.MaskedTextProvider.IsEditPosition(i) && (pos + max) >= i)
                        nextField = i;
                }
                nextField += 1;

                // We're done, enable the TabStop property again  
                if (pos == nextField)
                    maskedTextBoxNetworkIP_Leave(this, e);

                maskedTextBoxNetworkIP.SelectionStart = nextField;
            }
        }
    }
}
