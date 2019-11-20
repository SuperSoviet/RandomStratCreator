using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformversion {
  public partial class RandomStrat : Form {
    public RandomStrat() {
      InitializeComponent();
    }
    public override string Text {
      get; set;
    }

    private void lblstrat_Click(object sender, EventArgs e) {
      var random = new Random();
      var stratlist = new List<string>
      {
                "Do the Tyler1 : Run it down Mid",
                "Kayn main at heart : Play Rhaast but use shadow assassin items and runes",
                "Vayne is my main : Play full AD Vayne",
                "Helping my team from the jungle : Play a support in the jungle",
                "0 Deaths : try to have no deaths even if it causes your team to die"
      };
      int index = random.Next(stratlist.Count);
      lblstrat.Text = stratlist[index];
    }

    private void lblReturnMain_Click(object sender, EventArgs e) {
      Hide();
    }
  }
}
