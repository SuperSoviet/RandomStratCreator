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
  public partial class RandomOption : Form {
    private RandomChampion _inChampScreen = new RandomChampion();
    private RandomRole _inRandomRoleScreen = new RandomRole();
    private RandomStrat _inRandomStratScreen = new RandomStrat();
    public RandomOption() {
      InitializeComponent();
    }
    public override string Text {
      get; set;
    }

    private void lblReturnMain_Click(object sender, EventArgs e) {
      Hide();
    }

    private void lblRandomOption_Click(object sender, EventArgs e) {
      Random random = new Random();
      var option = random.Next(1, 4);

      if (option == 1) {
        Hide();
        _inChampScreen.Show();
      } else if (option == 2) {
        Hide();
        _inRandomRoleScreen.Show();
      }
      else if(option == 3){
        Hide();
        _inRandomStratScreen.Show();
      }
    }
  }
}
