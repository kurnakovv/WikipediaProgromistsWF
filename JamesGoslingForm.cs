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
    public partial class JamesgoslingForm : Form
    {
        public JamesgoslingForm()
        {
            InitializeComponent();
            textBox1.Text = InfoText.Message.JamesGoslingInfoText;
            TabStop = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
