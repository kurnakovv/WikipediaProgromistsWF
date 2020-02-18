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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void LinusTorvaldsPb_Click(object sender, EventArgs e)
        {
            var linusTorvalds = new LinusTorvaldsForm();
            linusTorvalds.ShowDialog();
        }

        private void DonaldKnutPb_Click(object sender, EventArgs e)
        {
            var donaldKnut = new DonaldKnutForm();
            donaldKnut.ShowDialog();
        }

        private void SirTimBernersLeePb_Click(object sender, EventArgs e)
        {
            var sirTimBernersLee = new SirTimBernersLeeForm();
            sirTimBernersLee.ShowDialog();
        }

        private void AndersHalesburgPb_Click(object sender, EventArgs e)
        {
            var andersHalesburg = new AndersHalesburgForm();
            andersHalesburg.ShowDialog();
        }

        private void BramCohenPb_Click(object sender, EventArgs e)
        {
            var bramCohen = new BramCohenForm();
            bramCohen.ShowDialog();
        }

        private void MarkZuckerbergPb_Click(object sender, EventArgs e)
        {
            var markZuckerberg = new MarkZuckerbergForm();
            markZuckerberg.ShowDialog();
        }

        private void BrendanIkePb_Click(object sender, EventArgs e)
        {
            var brendanIke = new BrendanIkeForm();
            brendanIke.ShowDialog();
        }

        private void BjörnStraustrupPb_Click(object sender, EventArgs e)
        {
            var björnStraustrup = new BjörnStraustrupForm();
            björnStraustrup.ShowDialog();
        }

        private void JohnCarmackPb_Click(object sender, EventArgs e)
        {
            var johnCarmack = new JohnCarmackForm();
            johnCarmack.ShowDialog();
        }

        private void JamesGoslingPb_Click(object sender, EventArgs e)
        {
            var jamesgosling = new JamesgoslingForm();
            jamesgosling.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            string message = "Вы действительно хотите выйти?";
            string caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                Close();
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
    }
}
