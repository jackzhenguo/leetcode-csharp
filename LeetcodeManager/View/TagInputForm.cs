using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetcodeManager.View
{
    public partial class TagInputForm : Form
    {
        private string _inputval;
        public TagInputForm()
        {
            InitializeComponent();
        }

        public TagInputForm(string inputval):this()
        {
            _inputval = inputval;
            textBox1.Text = _inputval;
        }
        public string InputTag
        {
            get
            {
                _inputval = textBox1.Text;
                return textBox1.Text;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
