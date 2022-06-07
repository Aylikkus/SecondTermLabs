using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphics
{
    public partial class PromptForm : Form
    {
        public PaintForm pf { get; set; }
        public PromptForm(PaintForm pf)
        {
            InitializeComponent();
            numericUpDown.Value = 4;
            numericUpDown.Increment = 3;

            this.pf = pf;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            pf.DrawBeziers(Convert.ToInt32(numericUpDown.Value));
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Value % 3 != 1)
                numericUpDown.Value = 4;
        }
    }
}
