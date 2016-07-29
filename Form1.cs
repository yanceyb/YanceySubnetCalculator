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
            maskedTextBox1.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Invalid IP";
                toolTip1.Show("Not a valid IP.", maskedTextBox1, 0, 0, 5000);
            }
        }
    }
}
