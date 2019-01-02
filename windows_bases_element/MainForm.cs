using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_bases_element
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Button clicked";
            maskedTextBox1.Text = "Button clicked";
            checkBox1.Checked = true;
            radioButton1.Checked = true;
            comboBox1.SelectedItem = 1;
        }
    }
}
