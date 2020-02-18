using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikipediaProgromistsWF
{
    public partial class SirTimBernersLeeForm : Form
    {
        public SirTimBernersLeeForm()
        {
            InitializeComponent();
            textBox1.Text = InfoText.Message.SirTimBernersLeeInfoText;
            TabStop = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }
    }
}
