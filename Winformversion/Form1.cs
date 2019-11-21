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

namespace Winformversion {
  public partial class Form1 : Form {
    private RandomOption _inRandomOptionScreen = new RandomOption();
    
    public Form1() {
      InitializeComponent();

    }

    private void btnExit_Click(object sender, EventArgs e) {
      Close();
    }
    private void btnRandomChampion_Click(object sender, EventArgs e) {
      RandomChampion ChampScreen = new RandomChampion();
      ChampScreen.Show();
    }

    private void btnRoleSelector_Click(object sender, EventArgs e) {
      RandomRole RandomRoleScreen = new RandomRole();
      RandomRoleScreen.Show();
    }

    private void btnStrat_Click(object sender, EventArgs e) {
      RandomStrat RandomStratScreen = new RandomStrat();
      RandomStratScreen.Show();
    }

    private void btnRandomOption_Click(object sender, EventArgs e) {
      RandomOption RandomOptionScreen = new RandomOption();
      RandomOptionScreen.Show();
    }
    private void lblSecret_Click_1(object sender, EventArgs e) {
      System.Diagnostics.Process.Start("https://www.reddit.com/r/KaynMains/");

    }

    private void btnMyProfile_Click(object sender, EventArgs e) {
      LeagueProfile inOpgg = new LeagueProfile();
      inOpgg.Show();
    }
    private void btnDiscord_Click(object sender, EventArgs e) {
      discord DiscordWindow = new discord();
      DiscordWindow.Show();
    }

    private void lblGithub_Click(object sender, EventArgs e) {
      MyGithub ingithub = new MyGithub();
      ingithub.Show();
    }
  }
}
