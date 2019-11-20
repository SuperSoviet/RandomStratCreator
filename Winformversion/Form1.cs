using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Winformversion
{
    public partial class Form1 : Form
    {
        private RandomChampion _inChampScreen = new RandomChampion();
    private RandomRole _inRandomRoleScreen = new RandomRole();
    private RandomStrat _inRandomStratScreen = new RandomStrat();
    private RandomOption _inRandomOptionScreen = new RandomOption();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRandomChampion_Click(object sender, EventArgs e)
        {
            _inChampScreen.Show();
        }

    private void button4_Click(object sender, EventArgs e) {
      _inRandomRoleScreen.Show();
    }

    private void lblLinkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      lblLinkGithub.LinkVisited = true;

      System.Diagnostics.Process.Start("https://github.com/SuperSoviet");
    }

    private void lblStrat_Click(object sender, EventArgs e) {
      _inRandomStratScreen.Show();
    }

    private void lblRandomOption_Click(object sender, EventArgs e) {
      _inRandomOptionScreen.Show();
    }
  }
}
